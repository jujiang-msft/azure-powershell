### Example 1: Deletes a Test Base Account
```powershell
PS C:\> Remove-AzTestBaseAccount -AccountName "testBaseAccount0902_test" -ResourceGroupName "testbase_rg"

No result is returned from this operation.
```

Deletes a Test Base Account.

### Example 2: Deletes a Test Base Account
```powershell
PS C:\> $inputObjs=@{SubscriptionId="9fabf001-9c1f-4aab-9451-e431da271956";ResourceGroupName="testbase_rg";TestBaseAccountName="testBaseAccount9493"}
Remove-AzTestBaseAccount -InputObject $inputObjs


The operation succeeded, but no result is returned.
```

Deletes a Test Base Account.

