# C# Project
## By Usarneme/Tom

---

### Project Description


This repo holds a bash script for creating the directory structure and boilerplate code files for a TDD-ready C#/.NET project.

---
### Bash Setup Script Instructions
1. Ensure script is executable using `chmod u+x setup.sh` NOTE: You may have to use sudo
2. Run the script. Mac: `sh setup.sh`. Linux: `./setup.sh`
3. Follow the prompt to enter the name of your project and hit enter.
NOTE: Don't forget to run `dotnet restore` once you have written some actual class/test code.

---

### Tech Stack
1. C#
2. .NET5
3. MSTest
4. Bash script (for project setup)

---
### Project Build/Run Instructions
1. Clone this repository via `git clone https://github.com/Usarneme/PROJECTNAME.Solution`
2. Enter the newly created directory via `cd PROJECTNAME.Solution/`
3. Enter the project directory `cd PROJECTNAME/` and install requirements via `dotnet restore`
4. From within the `PROJECTNAME/` project directory, first run `dotnet build` then `dotnet run`
5. (Optional) If you want to run the Test Suite, enter the test directory `cd PROJECTNAME.Tests/` and run `dotnet restore` followed by `dotnet test`

---

### Requirements
1. C# - instructions for installing can be found at https://www.geeksforgeeks.org/how-to-install-and-setup-visual-studio-for-c-sharp/
2. .NET - instructions for installing can be found at https://docs.microsoft.com/en-us/dotnet/framework/install/guide-for-developers
3. A terminal/command line application such as iTerm on Mac or CMD/GitBash on Windows

---
### Known Issues:
1. NO KNOWN ISSUES
2. Please open a pull request if you have any issues!

---

### License is GPLv3 and I make no claim to copyright.
<br />
<br />
<br />
<br />
<br />
<p align="center">
  <small>Made with ❤️ in Portland, Oregon. </small>
</p>