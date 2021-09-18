### Example 1: Gets an OS Update by name in which the package was tested before
```powershell
PS C:\> Get-AzTestBaseOSUpdate -AccountName "ContosoAccount" -Name "Windows-10-2004-2020-12-B-505" -PackageName "ContosoPackage-Version" -ResourceGroupName "ContosoRG"

Name                             Type
----                             ----
Windows-10-2004-2020-12-B-505    testBaseAccounts/packages/osUpdates

```

Gets an OS Update by name in which the package was tested before.

### Example 2: Get a List of OSUpdates
```powershell
PS C:\> Get-AzTestBaseOSUpdate -AccountName "ContosoAccount" -PackageName "ContosoPackage-Version" -ResourceGroupName "ContosoRG" -OSUpdateType "SecurityUpdate"

Name                                  Type
----                                  ----
Windows-10-2004-2020-12-B-505         testBaseAccounts/packages/osUpdates


```

Get a List of OSUpdates.

