@echo off
pushd "%~dp0"

if exist RedistPackages rd /s /q RedistPackages
if not exist RedistPackages mkdir RedistPackages

set projectname=System.Net.FtpClient.Async
.nuget\NuGet.exe pack %projectname%\%projectname%.csproj -IncludeReferencedProjects -Build -Symbols -OutputDirectory RedistPackages -Verbosity detailed -Properties Configuration=Release
.nuget\NuGet.exe push RedistPackages\%projectname%.nupkg

pause
popd
@echo on