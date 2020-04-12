$source = "./Strings.Tests/TestResults"
$destination = $source
$filter = "coverage.cobertura.xml"
Get-ChildItem -Recurse -Path $source | Where-Object { $_.Name -match $filter } | Copy-Item -Destination $destination