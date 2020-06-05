# xunit-sample

#InstallPrerequsites:

## VS Code Plugins - coverlet and Covergae Gutters

## Report Generator - use command below
## dotnet tool install -g dotnet-reportgenerator-globaltool

#To run tests

## cd test
## dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover

#This will generate a file named test\coverage.opencover.xml.

# Run ReportGenerator tool
# ReportGenerator.exe -reports:coverage.opencover.xml -targetdir:.\html -sourcedirs:..\impl

This will generatr html reports in the test\html folder
