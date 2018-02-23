```shell
dotnet add reference Microsoft.Packaging.Tools.Trimming -v 1.1.0-preview1-25818-01
dotnet build /p:TrimUnusedDependencies=true
```
[Microsoft.Packaging.Tools.Trimming](https://github.com/dotnet/standard/blob/release/2.0.0/Microsoft.Packaging.Tools.Trimming/docs/trimming.md)

note: https://blogs.msdn.microsoft.com/webdev/2017/11/09/creating-a-minimal-asp-net-core-windows-container/