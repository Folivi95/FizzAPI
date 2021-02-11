# FizzAPI
ASP.NET Core RESTful API to implement Fizz Algoirithm

## Preparing Development Environment

## System Requirements
* 1.8 GHz or faster processor. Quad-core or better recommended
* 2 GB of RAM; 8 GB of RAM recommended (2.5 GB minimum if running on a virtual machine)
* Hard disk space: Minimum of 800MB up to 210 GB of available space, depending on features installed; typical installations require 20-50 GB of free space.
* Hard disk speed: to improve performance, install Windows and Visual Studio on a solid state drive (SSD).
* Video card that supports a minimum display resolution of 720p (1280 by 720); Visual Studio will work best at a resolution of WXGA (1366 by 768) or higher.

## Supported operating systems
* Windows 10 Client Version 1607+ x64, x86
* macOS High Sierra (10.13+) x64
* Ubuntu 16.04+ x64, ARM32, ARM4
* You can use any Linux distribution which inheritance from Debian based

## Prerequisites
Before you begin, ensure you have installed the following
* Install the .NET Core `SDK 3.1.3.01`. Download link can be found [here](https://docs.microsoft.com/en-us/dotnet/core/install/sdk?pivots=os-windows) - Choose an operating system of your choice to download SDK.
* Install the `ASP.NET Core Runtime 3.1.5`. Download link can be found [here](https://dotnet.microsoft.com/download/dotnet-core/3.1) - Choose runtime for your OS
* Install Visual studio code or visual studio ide development environment.

## Steps to Run the application
* Open the solution in visual studio or visual studio code.
* Navigate to `FizzAPI` and set as startup project (if not already set by default).
* Run the following command `dotnet run` to run the project.
* API documentation is available on the OpenAPI swagger docs page located at `https://localhost:44356/OpenAPI/index.html` after running the application.
* Unit tests are in `FizzAPI.Test.Unit` folder.
* Functional tests are in `FizzAPI.Test.Integration` folder.
* Run the following command `dotnet test` to run the unit and integration tests.
