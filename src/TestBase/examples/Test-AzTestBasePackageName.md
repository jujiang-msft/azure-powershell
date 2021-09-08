### Example 1: Checks that the Test Base Package name and version
```powershell
PS C:\> Test-AzTestBasePackageName -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg" -ApplicationName "package2_kaifa" -Name "package2_kaifa-1.0" -Type "package" -Version "1.0" 

Message                                                       NameAvailable Reason
-------                                                       ------------- ------
ApplicationName: package2_kaifa, Version: 1.0 already exists. False         AlreadyExists

```

Checks that the Test Base Package name and version is valid and is not already in use.

### Example 2: Checks that the Test Base Package name and version
```powershell
PS C:\> Test-AzTestBasePackageName -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg" -Parameter @{ApplicationName="package_0907";Name="package_0907-1.0.0";Type="package";Version="1.0.0"}

Message NameAvailable Reason
------- ------------- ------
        True

```

Checks that the Test Base Package name and version is valid and is not already in use.

