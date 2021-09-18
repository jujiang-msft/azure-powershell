### Example 1: Gets an Analysis Result of a Test Result by name.
```powershell
PS C:\> Get-AzTestBaseAnalysisResult -AccountName "ContosoAccount" -Name "" -PackageName "ContosoPackage-Version" -ResourceGroupName "ContosoRG" -TestResultName "Windows-10-1909-99b1f80d-03a9-4148-997f-806ba5bac8e0"

Name            Type
----            ----


```

Gets an Analysis Result of a Test Result by name.

### Example 2: Get a List of AnalysisResults
```powershell
PS C:\> Get-AzTestBaseAnalysisResult -AccountName "ContosoAccount" -PackageName "ContosoPackage" -ResourceGroupName "ContosoRG" -TestResultName "ContosoResult" -AnalysisResultType "scriptExecution"

Name            Type
----            ----
scriptExecution testBaseAccounts/packages/testResults/analysisResults

```

Get a List of AnalysisResults.

