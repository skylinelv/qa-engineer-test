using NUnit.Framework;
using AltTester.AltTesterSDK.Driver;

public class Tests
{
    private AltDriver altDriver;

    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver = new AltDriver();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void IsButtonInteractable()
    {
        altDriver.FindObject(By.NAME, "SubmitButton").Tap();

        var button = altDriver.WaitForObject(By.NAME, "SubmitButton");

        Assert.IsTrue(button.enabled);
    }

    [Test]
    public void DoesValueIncreaseOnClick()
    {
        int countNow = int.Parse(altDriver.FindObject(By.NAME, "Count").GetText());

        altDriver.FindObject(By.NAME, "SubmitButton").Tap();

        int countAfterClick = int.Parse(altDriver.FindObject(By.NAME, "Count").GetText());

        Assert.AreEqual(countNow + 1, countAfterClick);

    }

    [Test]
    public void DoesValueIncreaseBy10After10Clicks()
    {
        var countNow = int.Parse(altDriver.FindObject(By.NAME, "Count").GetText());

        for (int i = 0; i < 10; i++)
        {
            altDriver.FindObject(By.NAME, "SubmitButton").Tap();
        }

        var countAfterClicks = int.Parse(altDriver.FindObject(By.NAME, "Count").GetText());
        int countFinal = countAfterClicks - countNow;

        Assert.AreEqual(10, countFinal);
    }
    
}