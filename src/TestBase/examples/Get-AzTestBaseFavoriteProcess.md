### Example 1: Gets a favorite process for a Test Base Package
```powershell
PS C:\> Get-AzTestBaseFavoriteProcess -AccountName "ContosoAccount" -Name "ContosoProcess" -PackageName "ContosoPackage-Version" -ResourceGroupName "ContosoRG"

Name Type
---- ----


```

Gets a favorite process for a Test Base Package.

### Example 2: Get a List of FavoriteProcesses
```powershell
PS C:\> Get-AzTestBaseFavoriteProcess -AccountName "ContosoAccount" -PackageName "ContosoPackage-Version" -ResourceGroupName "ContosoRG"

Name Type
---- ----







```

Get a List of FavoriteProcesses.

