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
PS C:\> $inputObjs=@{SubscriptionId="9fabf001-9c1f-4aab-9451-e431da271956";ResourceGroupName="testbase_rg";TestBaseAccountName="testBaseAccount_kaifa";PackageName="package2_kaifa-1.0"}
Update-AzTestBasePackage -InputObject $inputObjs -Tag @{test="0907"}

Etag Location Name               Type                                         AzureAsyncOperation
---- -------- ----               ----                                         -------------------
     global   package2_kaifa-1.0 microsoft.testbase/testbaseaccounts/packages

```

Update an existing Test Base Package.

