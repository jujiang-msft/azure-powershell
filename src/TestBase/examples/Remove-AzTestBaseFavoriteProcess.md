### Example 1: Deletes a favorite process for a specific package
```powershell
PS C:\> Remove-AzTestBaseFavoriteProcess -AccountName "ContosoAccount" -PackageName "ContosoPackage" -ResourceGroupName "ContosoRG" -ResourceName "ContosoProcess"

The operation succeeded, but no result was returned.
```

Deletes a favorite process for a specific package.

### Example 2: Deletes a favorite process for a specific package
```powershell
PS C:\> $inputObjs=@{SubscriptionId="9fabf001-9c1f-4aab-9451-e431da271956";ResourceGroupName="ContosoRG";TestBaseAccountName="ContosoAccount";PackageName="ContosoPackage";FavoriteProcessResourceName="ContosoProcess"}
Remove-AzTestBaseFavoriteProcess -InputObject $inputObjs 

The operation succeeded, but no result was returned.
```

Deletes a favorite process for a specific package.

