### Example 1: Update an existing Test Base Package
```powershell
PS C:\> Update-AzTestBasePackage -AccountName "ContosoAccount" -Name "ContosoPackage-1.0.0" -ResourceGroupName "ContosoRG"

Etag Location Name                 Type                                         AzureAsyncOperation
---- -------- ----                 ----                                         -------------------
     global   ContosoPackage-1.0.0 microsoft.testbase/testbaseaccounts/packages

```

Update an existing Test Base Package.

### Example 2: Update an existing Test Base Package
```powershell
PS C:\> $inputObjs=@{SubscriptionId="9fabf001-9c1f-4aab-9451-e431da271956";ResourceGroupName="ContosoRG";TestBaseAccountName="ContosoAccount";PackageName="ContosoPackage-1.0.0"}
Update-AzTestBasePackage -InputObject $inputObjs -Tag @{test="test"}

Etag Location Name                 Type                                         AzureAsyncOperation
---- -------- ----                 ----                                         -------------------
     global   ContosoPackage-1.0.0 microsoft.testbase/testbaseaccounts/packages

```

Update an existing Test Base Package.

