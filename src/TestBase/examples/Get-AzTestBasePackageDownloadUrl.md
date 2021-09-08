### Example 1: Gets the download URL of a package
```powershell
PS C:\> Get-AzTestBasePackageDownloadUrl -AccountName "testBaseAccount_kaifa" -PackageName "package2_kaifa-1.0" -ResourceGroupName "testbase_rg"

DownloadUrl
-----------
https://tbwestusppesa.blob.core.windows.net/c0097881-16f2-4c2a-b6f1-1e2c7d7cb8e7/prod/97fc8542-091d-45be-9b89-d6441123d6da/9b423c8f-dd93-4b5e-ba1d-dc10064d5566/1/test.zip?sv=2019-07-07&sr=b&sig=ZuSCNS8CJpuwa56W%2Bg8ImwvUHoZYp%2FZahgza0…
```

Gets the download URL of a package.

### Example 2: Gets the download URL of a package
```powershell
PS C:\> $inputObjs=@{SubscriptionId="9fabf001-9c1f-4aab-9451-e431da271956";ResourceGroupName="testbase_rg";TestBaseAccountName="testBaseAccount_kaifa";PackageName="package2_kaifa-1.0"}
Get-AzTestBasePackageDownloadUrl -InputObject $inputObjs

DownloadUrl
-----------
https://tbwestusppesa.blob.core.windows.net/c0097881-16f2-4c2a-b6f1-1e2c7d7cb8e7/prod/97fc8542-091d-45be-…

```

Gets the download URL of a package.
