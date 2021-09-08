### Example 1: Gets the file upload URL of a package
```powershell
PS C:\> Get-AzTestBasePackageBlobPath -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg" -FileName "test.zip"

{{ Add output here }}
```

Gets the file upload URL of a package.

### Example 2: Gets the file upload URL of a package
```powershell
PS C:\> Get-AzTestBasePackageBlobPath -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg" -Parameter @{BlobName="test.zip"}

BlobPath                                                                                UploadUrl
--------                                                                                ---------
c0097881-16f2-4c2a-b6f1-1e2c7d7cb8e7/temp/67ae1556-b0d0-4fdd-952a-3ce7f6238db5/test.zip https://tbwestusppesa.blob.core.windows.net/c0097881-16f2-4c2a-b6f1-1e2c7d7cb8e7/temp/67ae1556-b0d0-4fdd-952a-3ce7f6238db5/test.zip?sv=2019-07-07&s…

```

Gets the file upload URL of a package.

