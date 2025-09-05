# AltTester QA Project

Automated tests for the **QA Engineer test project** using [AltTester Desktop](https://alttester.com/downloads/) and Unity.

This project validates the functionality of a simple counter button in a Unity application.

---

## Project Structure
```
qa-engineer-test/
├─ Assets/
│ └─ Editor/
│ └─ Tests.cs # Test scenarios
├─ Packages/
│ └─ manifest.json # Unity packages config
├─ Builds/ # Test builds will be generated here
└─ README.md # This file
```
---

## Test Scenarios

1. **Verify that the "Count" button is interactable.**  
2. **Verify that the "Count" value increases when the button is pressed.**  
3. **Verify that the "Count" value reaches 10 after 10 presses.**  

---

## Prerequisites

* [Unity 2022.3.62f1 LTS](https://unity.com/releases/editor/whats-new/2022.3.62f1)  
* [AltTester® Desktop (Community/Pro/Enterprise) for Windows](https://alttester.com/downloads/)  
* [AltTester Unity SDK](https://alttester.com/downloads/)  

---

## Setup Guide

### 1. Clone Repository
```
git clone https://github.com/skylinelv/qa-engineer-test.git
```
```
cd qa-engineer-test
```
```
git checkout add-tests
```

### 2. Open in Unity
Open Unity Hub → *Add project from disk* → select project folder.

Ignore initial compilation errors (AltTester SDK is not yet imported).

### 3. Import AltTester SDK
In Unity: `Assets → Import package → Custom package.`

Select the downloaded AltTester Unity SDK .unitypackage.

### 4. Configure AltTester
Open: `AltTester → AltTester Editor.`

In **Scene Manager**, add `SampleScene.unity` and check its tickbox.

Create a new folder `Builds/` in the project root folder.

In **Build Location**, select the new `Builds/` folder.

### 5. Run Tests
Start AltTester Desktop.

In Unity’s AltTester Editor → press `Build & Run.`

In AltTester Desktop → press `Connect.`

In Unity’s AltTester Editor → press `Run All Tests (3).`

Wait until all tests are executed.

After running tests, check the Unity Console to see the test results — you should see messages indicating that all tests have passed.

##  Troubleshooting

- **Error:** `AltTester.AltTesterSDK.Driver.ComponentNotFoundException`  
  ➝ Ensure that `SampleScene.unity` is added and checked in **AltTester → AltTester Editor → Scene Manager**.  

- **AltTester Desktop cannot connect**  
  ➝ Verify that AltTester Desktop is running **before** pressing *Build & Run*.  
  ➝ Check that the **IP address** and **port** in Unity’s AltTester Editor **match** the ones configured in AltTester Desktop (default is `127.0.0.1:13000`).  
  ➝ If another process is using the same port, change the port number in **both Unity and AltTester Desktop**.  

- **Compilation errors about Newtonsoft.Json**  
  ➝ Add `com.unity.nuget.newtonsoft-json` to your `Packages/manifest.json`.  

- **Unity build does not start or closes immediately**  
  ➝ Delete the `Builds/` folder and rebuild.  
  ➝ Ensure that your **Build Location** path in AltTester Editor points to a valid folder.  

- **Tests don’t run or hang indefinitely**  
  ➝ Check that the **AltTester Server** in Unity Editor is running (`AltTester → AltTester Editor → Start Server`).  
  ➝ Make sure no firewall/antivirus is blocking the connection between Unity and AltTester Desktop.  
  ➝ If tests still hang, restart both Unity and AltTester Desktop.  

- **Scene not loaded or elements not found**  
  ➝ Confirm that the correct scene (e.g., `SampleScene.unity`) is included in the **Scenes In Build** list (Unity → File → Build Settings).  


## Notes
Keep **AltTester Desktop** running while executing tests.

All tests are located in `Assets/Editor/Tests.cs.`

Builds will be generated in the `Builds/` folder.
