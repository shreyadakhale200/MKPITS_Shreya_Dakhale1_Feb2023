$files = Get-ChildItem -Recurse -Filter *.csproj

foreach ($file in $files) {
    Write-Host "Adding package reference to $($file.FullName)"
    dotnet add "$($file.FullName)" package System.Data.SqlClient --version 4.0.1
}
