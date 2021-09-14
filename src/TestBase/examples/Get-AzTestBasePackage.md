### Example 1: Gets a Test Base Package
```powershell
PS C:\> Get-AzTestBasePackage -AccountName "ContosoAccount" -Name "ContosoPackage" -ResourceGroupName "ContosoRG"

Etag Location Name               Type                                         AzureAsyncOperation
---- -------- ----               ----                                         -------------------
     global   ContosoPackage microsoft.testbase/testbaseaccounts/packages

```

Gets a Test Base Package.

### Example 2: Get a List of Packages
```powershell
PS C:\> Get-AzTestBasePackage -AccountName "ContosoAccount" -ResourceGroupName "ContosoRG"

Etag Location Name                    Type                                         AzureAsyncOperation
---- -------- ----                    ----                                         -------------------
     global   ContosoPackage      microsoft.testbase/testbaseaccounts/packages
……

```

Get a List of Packages.

