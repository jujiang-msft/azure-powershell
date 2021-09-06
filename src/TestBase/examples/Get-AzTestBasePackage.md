### Example 1: Gets a Test Base Package
```powershell
PS C:\> Get-AzTestBasePackage -AccountName "testBaseAccount_kaifa" -Name "package2_kaifa-1.0" -ResourceGroupName "testbase_rg"

Etag Location Name               Type                                         AzureAsyncOperation
---- -------- ----               ----                                         -------------------
     global   package2_kaifa-1.0 microsoft.testbase/testbaseaccounts/packages

```

Gets a Test Base Package.

### Example 2: Get a List of Packages
```powershell
PS C:\> Get-AzTestBasePackage -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg"

Etag Location Name                    Type                                         AzureAsyncOperation
---- -------- ----                    ----                                         -------------------
     global   package1_kaifa-2.0      microsoft.testbase/testbaseaccounts/packages
     global   package2_kaifa-1.0      microsoft.testbase/testbaseaccounts/packages
     global   testbase7023_pkg-1.0.0  microsoft.testbase/testbaseaccounts/packages
     global   testbase9360_pkg-1.0.0  microsoft.testbase/testbaseaccounts/packages
     global   testbase478_pkg-1.0.0   microsoft.testbase/testbaseaccounts/packages
     global   testbase9995_pkg-1.0.0  microsoft.testbase/testbaseaccounts/packages
     global   testbase4192_pkg-1.0.0  microsoft.testbase/testbaseaccounts/packages
     global   testbase4897_pkg-1.0.0  microsoft.testbase/testbaseaccounts/packages
     global   testbase1196_pkg-1.0.0  microsoft.testbase/testbaseaccounts/packages
     global   testbase1981_pkg-1.0.0  microsoft.testbase/testbaseaccounts/packages
     global   package9648_kaifa-1.0.0 microsoft.testbase/testbaseaccounts/packages
     global   package4417_kaifa-1.0.0 microsoft.testbase/testbaseaccounts/packages

```

Get a List of Packages.

