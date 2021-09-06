### Example 1: Update an existing Test Base Package
```powershell
PS C:\> Update-AzTestBasePackage -AccountName "testBaseAccount0825_test" -Name "package0831-1.0.0" -ResourceGroupName "testbase_rg"

Etag Location Name              Type                                         AzureAsyncOperation
---- -------- ----              ----                                         -------------------
     global   package0831-1.0.0 microsoft.testbase/testbaseaccounts/packages

```

Update an existing Test Base Package.

### Example 2: Update an existing Test Base Package
```powershell
PS C:\> Update-AzTestBasePackage -InputObject <ITestBaseIdentity>

{{ Add output here }}
```

Update an existing Test Base Package.

