### Example 1: Gets the download URL of a package
```powershell
PS C:\> Get-AzTestBasePackageDownloadUrl -AccountName "ContosoAccount" -PackageName "ContosoPackage-Version" -ResourceGroupName "ContosoRG"

DownloadUrl
-----------
some URL

```

Gets the download URL of a package.

### Example 2: Gets the download URL of a package
```powershell
PS C:\> $inputObjs=@{SubscriptionId="476f61a4-952c-422a-b4db-568a828f35df";ResourceGroupName="ContosoRG";TestBaseAccountName="ContosoAccount";PackageName="ContosoPackage-Version"}
Get-AzTestBasePackageDownloadUrl -InputObject $inputObjs

DownloadUrl
-----------
some URL

```

Gets the download URL of a package.
