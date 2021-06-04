@echo off

dotnet restore

dotnet build --no-restore -c Release

dotnet nuget push Panosen.CodeDom\bin\Release\Panosen.CodeDom.*.nupkg -s https://package.savory.cn/v3/index.json --skip-duplicate

move /Y Panosen.CodeDom\bin\Release\Panosen.CodeDom.*.nupkg D:\LocalSavoryNuget\

pause