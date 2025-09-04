# AltTester QA Project

Automated tests for the QA Engineer test project using **AltTester Desktop v.2.2.4**.

## Project Structure

Assets/
└─ Editor/
   └─ Tests.cs       # Test scenarios
Packages/
└─ manifest.json     # Unity packages config
README.md            # This file

## Test Scenarios

1. Count button is interactable.
2. Count value increases when button is pressed.
3. Count value reaches 10 after 10 presses.

## Prerequisites

* Unity 2022.3.62f1 LTS -> https://unity.com/releases/editor/whats-new/2022.3.62f1
* AltTester® Desktop (Community/Pro/Enterprise) for Windows -> https://alttester.com/downloads/
* AltTester Unity SDK -> https://alttester.com/downloads/

## Setup Guide
Open preferable project folder in terminal and use following commands:
* git clone https://github.com/skylinelv/qa-engineer-test.git
* cd qa-engineer-test
* git checkout add-tests

1. Open project in Unity Hub via Add -> Add project from disk.
2. Import AltTester SDK via Assets -> Import package -> Custom package.
3. Open AltTester Editor via AltTester -> AltTester Editor.
4. In Scene Manager section add SampleScene.unity and make sure that checkbox is ticked.
5. Make a new folder Builds in project folder and add folder path in Build Location section.
6. Open AltTester Desktop.
7. In Unity AltTester Editor press Build & Run.
8. In AltTester Desktop press connect.
9. In Unity AltTester Editor press Run All Tests (3)
10. Wait for tests to be completed.
   

## Notes

* Keep AltTester Desktop running when executing tests.
