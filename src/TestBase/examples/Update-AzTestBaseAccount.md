### Example 1: Update an existing Test Base Account
```powershell
PS C:\> Update-AzTestBaseAccount -Name "TESTBASEACCOUNT_KAIFA" -ResourceGroupName "testbase_rg"  -Tag @{test="test0906"}

Etag Location Name                  Type                                AzureAsyncOperation
---- -------- ----                  ----                                -------------------
     global   TESTBASEACCOUNT_KAIFA microsoft.testbase/testbaseaccounts

```

Update an existing Test Base Account.

### Example 2: Update an existing Test Base Account
```powershell
PS C:\> $inputObjs=@{SubscriptionId="9fabf001-9c1f-4aab-9451-e431da271956";ResourceGroupName="testbase_rg";TestBaseAccountName="testBaseAccount_kaifa"}
Update-AzTestBaseAccount -InputObject $inputObjs -Tag @{test="0907";test1="0907_1"}

Etag Location Name                  Type                                AzureAsyncOperation
---- -------- ----                  ----                                -------------------
     global   TESTBASEACCOUNT_KAIFA microsoft.testbase/testbaseaccounts

```

Update an existing Test Base Account.

