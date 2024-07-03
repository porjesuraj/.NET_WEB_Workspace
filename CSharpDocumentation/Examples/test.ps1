dotnet run
if($LastExitCode -eq 0)
{
  Write-Host "Executed successfully"
}else
{
  Write-Host "Execution failed"
}
  Write-Host "Return Value : " = $LastExitCode


