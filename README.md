xunit-sample
====================

Install Prerequsites
---------------------
Install the following VS Code Plugins:
* C# for Visual Studio Code - by OmniSharp

Install the following VS code plugins if you need to run unit tests:
* .NET Core Test Explorer
* Coverlet
* Coverage Gutters

Install Report Generator using the command below

<code>
dotnet tool install -g dotnet-reportgenerator-globaltool
</code>

To build and run implementation code
---------------------
From powershell, run the following commands from the solution dir 
<code>
  dotnet build .\xunit.sln
  dotnet run --project .\impl\
</code>

To run tests
------------

<code>
cd test

dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
</code>
  
This will generate a file named test\coverage.opencover.xml.

Run ReportGenerator tool
------------------------

<code>
ReportGenerator.exe -reports:coverage.opencover.xml -targetdir:.\html -sourcedirs:..\impl
</code>
<br/><br/>
This will generate html reports in the test\html folder

Code analysis and rules
------------------------
The project uses the Microsoft.CodeAnalysis.FxCopAnalyzers nuget package as a code analysis tool.
There is a ruleset file included in this repository. It can be tweaked to throw build errors if a rule is violated.
Example from the ruleset file:
<!-- <Rule Id="CA1801" Action="Error" /> -->
If you uncomment this line, the impl project will not build as the Main method has an argument (string[] args) which are not used in the method body.
The rule ids are defined by Microsoft and are all documented on MSDN.
Rule CA1801: Review unused parameters - https://docs.microsoft.com/en-us/visualstudio/code-quality/ca1801?view=vs-2019
