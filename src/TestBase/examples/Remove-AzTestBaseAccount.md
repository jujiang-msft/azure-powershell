### Example 1: Deletes a Test Base Account
```powershell
PS C:\> Remove-AzTestBaseAccount -AccountName "ContosoAccount" -ResourceGroupName "ContosoRG"

The operation succeeded, but no result is returned.
```

Deletes a Test Base Account.

### Example 2: Deletes a Test Base Account
```powershell
PS C:\> $inputObjs=@{SubscriptionId="9fabf001-9c1f-4aab-9451-e431da271956";ResourceGroupName="ContosoRG";TestBaseAccountName="ContosoAccount"}
Remove-AzTestBaseAccount -InputObject $inputObjs


The operation succeeded, but no result is returned.
```

Deletes a Test Base Account.

