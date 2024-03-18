Be sure to clone Covenant recursively to initialize the git submodules: git clone --recurse-submodules https://github.com/cobbr/Covenant
Option 1 - Dotnet Core

The easiest way to use Covenant is by installing dotnet core. You can download dotnet core for your platform from here.

Be sure to install the dotnet core version 3.1 SDK!

Once you have installed dotnet core, we can build and run Covenant using the dotnet CLI:

$ ~ > git clone --recurse-submodules https://github.com/cobbr/Covenant
$ ~ > cd Covenant/Covenant
$ ~/Covenant/Covenant > dotnet run
warn: Microsoft.EntityFrameworkCore.Model.Validation[10400]
      Sensitive data logging is enabled. Log entries and exception messages may include sensitive application data, this mode should only be enabled during development.
WARNING: Running Covenant non-elevated. You may not have permission to start Listeners on low-numbered ports. Consider running Covenant elevated.
Covenant has started! Navigate to https://127.0.0.1:7443 in a browser




![Covenant](https://raw.githubusercontent.com/wiki/cobbr/Covenant/covenant.png)
[![Contributors](https://img.shields.io/github/contributors/cobbr/Covenant)](https://github.com/cobbr/Covenant/graphs/contributors)
[![Commit Activity](https://img.shields.io/github/commit-activity/w/cobbr/covenant)](https://github.com/cobbr/Covenant/graphs/commit-activity)
[![Stars](https://img.shields.io/github/stars/cobbr/Covenant)](https://github.com/cobbr/Covenant/stargazers)
[![License](https://img.shields.io/github/license/cobbr/Covenant)](https://github.com/cobbr/Covenant/blob/master/LICENSE)
[![Chat](https://img.shields.io/badge/chat-%23covenant-red)](https://bloodhoundgang.herokuapp.com/)

Covenant is a .NET command and control framework that aims to highlight the attack surface of .NET, make the use of offensive .NET tradecraft easier, and serve as a collaborative command and control platform for red teamers.

Covenant is an ASP.NET Core, cross-platform application that includes a web-based interface that allows for multi-user collaboration.

![Covenant Dashboard](https://github.com/cobbr/Covenant/wiki/images/covenant-gui-dashboard.png)

## Quick-Start Guide

Please see the [Installation and Startup](https://github.com/cobbr/Covenant/wiki/Installation-And-Startup) guide to get started with Covenant!

The [Wiki](https://github.com/cobbr/Covenant/wiki) documents most of Covenant's core features and how to use them.

## Features

Covenant has several key features that make it useful and differentiate it from other command and control frameworks:

* **Intuitive Interface** - Covenant provides an intuitive web application to easily run a collaborative red team operation.
* **Multi-Platform** - Covenant targets .NET Core, which is multi-platform. This allows Covenant to run natively on Linux, MacOS, and Windows platforms. Additionally, Covenant has docker support, allowing it to run within a container on any system that has docker installed.
* **Multi-User** - Covenant supports multi-user collaboration. The ability to collaborate has become crucial for effective red team operations. Many users can interact with the same Covenant server and operate independently or collaboratively.
* **API Driven** - Covenant is driven by an API that enables multi-user collaboration and is easily extendible. Additionally, Covenant includes a Swagger UI that makes development and debugging easier and more convenient.
* **Listener Profiles** - Covenant supports listener “profiles” that control how the network communication between Grunt implants and Covenant listeners look on the wire.
* **Encrypted Key Exchange** - Covenant implements an encrypted key exchange between Grunt implants and Covenant listeners that is largely based on a similar exchange in the Empire project, in addition to optional SSL encryption. This achieves the cryptographic property of forward secrecy between Grunt implants.
* **Dynamic Compilation** - Covenant uses the Roslyn API for dynamic C# compilation. Every time a new Grunt is generated or a new task is assigned, the relevant code is recompiled and obfuscated with ConfuserEx, avoiding totally static payloads. Covenant reuses much of the compilation code from the SharpGen project, which I described in much more detail in a previous post.
* **Inline C# Execution** - Covenant borrows code and ideas from both the SharpGen and SharpShell projects to allow operators to execute C# one-liners on Grunt implants. This allows for similar functionality to that described in the SharpShell post, but allows the one-liners to be executed on remote implants.
* **Tracking Indicators** - Covenant tracks “indicators” throughout an operation, and summarizes them in the Indicators menu. This allows an operator to conduct actions that are tracked throughout an operation and easily summarize those actions to the blue team during or at the end of an assessment for deconfliction and educational purposes. This feature is still in it’s infancy and still has room for improvement.
* **Developed in C#** - Personally, I enjoy developing in C#, which may not be a surprise for anyone that has read my latest blogs or tools. Not everyone might agree that development in C# is ideal, but hopefully everyone agrees that it is nice to have all components of the framework written in the same language. I’ve found it very convenient to write the server, client, and implant all in the same language. This may not be a true “feature”, but hopefully it allows others to contribute to the project fairly easily.

### Questions and Discussion

Have questions or want to chat more about Covenant? Join the #Covenant channel in the [BloodHound Gang Slack](https://bloodhoundgang.herokuapp.com/).
