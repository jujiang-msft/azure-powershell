### Example 1: Gets an Analysis Result of a Test Result by name.
```powershell
PS C:\> Get-AzTestBaseAnalysisResult -AccountName "testBaseAccount_kaifa" -Name "" -PackageName "package2_kaifa-1.0" -ResourceGroupName "testbase_rg" -TestResultName "TestResult-8ea496b3-04bf-4a3d-a370-87d12c22a333"

{{ Add output here }}
```

Gets an Analysis Result of a Test Result by name.

### Example 2: Get a List of AnalysisResults
```powershell
PS C:\> Get-AzTestBaseAnalysisResult -AccountName "testBaseAccount_kaifa" -PackageName "package2_kaifa-1.0" -ResourceGroupName "testbase_rg"-TestResultName "TestResult-8ea496b3-04bf-4a3d-a370-87d12c22a333" -AnalysisResultType "scriptExecution"

Name            Type
----            ----
scriptExecution testBaseAccounts/packages/testResults/analysisResults

```

Get a List of AnalysisResults.

