### Example 1: Get the Test Result by Id with specified OS Update type for a Test Base Package
```powershell
PS C:\> Get-AzTestBaseTestResult -AccountName "ContosoAccount" -Name "Windows-10-1909-99b1f80d-03a9-4148-997f-806ba5bac8e0" -PackageName "ContosoPackage"  -ResourceGroupName "ContosoRG"

Name                                                 Type
----                                                 ----
Windows-10-1909-99b1f80d-03a9-4148-997f-806ba5bac8e0 testBaseAccounts/packages/testResults

```

Get the Test Result by Id with specified OS Update type for a Test Base Package.

### Example 2: Get a List of TestResults
```powershell
PS C:\> Get-AzTestBaseTestResult -AccountName "ContosoAccount" -PackageName "ContosoPackage"  -ResourceGroupName "ContosoRG" -OSUpdateType "SecurityUpdate" -Filter "osName eq 'Windows 10 21H1' and releaseName eq '2021.05 B' and buildRevision eq '985'"

Name                                                 Type
----                                                 ----
Windows-10-1909-99b1f80d-03a9-4148-997f-806ba5bac8e0 testBaseAccounts/packages/testResults

```

Get a List of TestResults.

