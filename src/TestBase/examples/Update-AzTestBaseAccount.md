### Example 1: Update an existing Test Base Account
```powershell
PS C:\> Update-AzTestBaseAccount -Name "ContosoAccount" -ResourceGroupName "ContosoRG"  -Tag @{test="test"}

Etag Location Name                  Type                                AzureAsyncOperation
---- -------- ----                  ----                                -------------------
     global   ContosoAccount microsoft.testbase/testbaseaccounts

```

Update an existing Test Base Account.

### Example 2: Update an existing Test Base Account
```powershell
PS C:\> $inputObjs=@{SubscriptionId="9fabf001-9c1f-4aab-9451-e431da271956";ResourceGroupName="ContosoRG";TestBaseAccountName="ContosoAccount"}
Update-AzTestBaseAccount -InputObject $inputObjs -Tag @{test="test";test1="test1"}

Etag Location Name                  Type                                AzureAsyncOperation
---- -------- ----                  ----                                -------------------
     global   ContosoAccount microsoft.testbase/testbaseaccounts

```

Update an existing Test Base Account.

