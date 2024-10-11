@echo off
dotnet.exe tool install -g dotnet-reportgenerator-globaltool
rd /s/q TestResults    
rd /s/q TestCoverage
dotnet.exe test --collect:"XPlat Code Coverage"
FOR /F %%i IN ('dir coverage.cobertura.xml /s/b') DO set OutXml=%%i
reportgenerator.exe -reports:"%OutXml%" -targetdir:"TestCoverage" -reporttypes:Html
start TestCoverage\index.html