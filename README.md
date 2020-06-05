xunit-sample
====================

Install Prerequsites
---------------------
VS Code Plugins - Install coverlet and Covergae Gutters

Report Generator - use command below

<code>
dotnet tool install -g dotnet-reportgenerator-globaltool
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

This will generate html reports in the test\html folder
