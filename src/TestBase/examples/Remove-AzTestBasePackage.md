### Example 1: Deletes a Test Base Package
```powershell
PS C:\> Remove-AzTestBasePackage -AccountName "ContosoAccount" -PackageName "ContosoPackage" -ResourceGroupName "ContosoRG"

Manipulation succeeded, no results returned.
```

Deletes a Test Base Package.

### Example 2: Deletes a Test Base Package
```powershell
PS C:\> $inputObjs=@{SubscriptionId="9fabf001-9c1f-4aab-9451-e431da271956";ResourceGroupName="ContosoRG";TestBaseAccountName="ContosoAccount";PackageName="ContosoPackage"}
Remove-AzTestBasePackage -InputObject $inputObjs

Manipulation succeeded, no results returned.
```

Deletes a Test Base Package.

