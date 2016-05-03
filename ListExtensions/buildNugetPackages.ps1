nuget pack .\ListExtensions.nuspec -IncludeReferencedProjects -Prop Configuration=Release
nuget push *.nupkg