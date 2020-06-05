# xunit-sample

#InstallPrerequsites:

# VS Code Plugins - Install coverlet and Covergae Gutters

# Install Report Generator - use command below

dotnet tool install -g dotnet-reportgenerator-globaltool

#To run tests

cd test
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover

#This will generate a file named test\coverage.opencover.xml.

# Run ReportGenerator tool
ReportGenerator.exe -reports:coverage.opencover.xml -targetdir:.\html -sourcedirs:..\impl

This will generate html reports in the test\html folder
