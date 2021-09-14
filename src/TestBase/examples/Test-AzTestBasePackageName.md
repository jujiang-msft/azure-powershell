### Example 1: Checks that the Test Base Package name and version
```powershell
PS C:\> Test-AzTestBasePackageName -AccountName "ContosoAccount" -ResourceGroupName "ContosoRG" -ApplicationName "ContosoPackage" -Name "ContosoPackage-1.0.0" -Version "1.0.0" 

Message                                                       NameAvailable Reason
-------                                                       ------------- ------
ApplicationName: ContosoPackage, Version: 1.0.0 already exists. False         AlreadyExists

```

Checks that the Test Base Package name and version is valid and is not already in use.

### Example 2: Checks that the Test Base Package name and version
```powershell
PS C:\> Test-AzTestBasePackageName -AccountName "ContosoAccount" -ResourceGroupName "ContosoRG" -Parameter @{ApplicationName="ContosoPackage";Name="ContosoPackage-1.0.0";Type="package";Version="1.0.0"}

Message NameAvailable Reason
------- ------------- ------
        True

```

Checks that the Test Base Package name and version is valid and is not already in use.

