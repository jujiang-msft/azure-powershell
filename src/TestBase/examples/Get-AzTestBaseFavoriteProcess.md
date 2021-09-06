### Example 1: Gets a favorite process for a Test Base Package
```powershell
PS C:\> Get-AzTestBaseFavoriteProcess -AccountName "testBaseAccount_kaifa" -Name "testbase8713_favProcess" -PackageName "package2_kaifa-1.0" -ResourceGroupName "testbase_rg"

Name Type
---- ----


```

Gets a favorite process for a Test Base Package.

### Example 2: Get a List of FavoriteProcesses
```powershell
PS C:\> Get-AzTestBaseFavoriteProcess -AccountName "testBaseAccount_kaifa" -PackageName "package2_kaifa-1.0" -ResourceGroupName "testbase_rg"

Name Type
---- ----







```

Get a List of FavoriteProcesses.

