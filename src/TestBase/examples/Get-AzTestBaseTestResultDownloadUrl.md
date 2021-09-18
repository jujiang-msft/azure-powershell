### Example 1: Gets the download URL of the test result
```powershell
PS C:\> Get-AzTestBaseTestResultDownloadUrl -AccountName "ContosoAccount" -PackageName "ContosoPackage" -ResourceGroupName "ContosoRG" -TestResultName "Windows-10-1909-99b1f80d-03a9-4148-997f-806ba5bac8e0"

DownloadUrl
-----------
some URL

```

Gets the download URL of the test result.

### Example 2: Gets the download URL of the test result
```powershell
PS C:\> $inputObjs=@{SubscriptionId="476f61a4-952c-422a-b4db-568a828f35df";ResourceGroupName="ContosoRG";TestBaseAccountName="ContosoAccount";PackageName="ContosoPackage";TestResultName="Windows-10-1909-99b1f80d-03a9-4148-997f-806ba5bac8e0"}
Get-AzTestBaseTestResultDownloadUrl -InputObject $inputObjs 

DownloadUrl
-----------
some URL

```

Gets the download URL of the test result.

