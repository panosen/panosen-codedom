@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.CodeDom\bin\Release\Panosen.CodeDom.*.nupkg D:\LocalSavoryNuget\

pause