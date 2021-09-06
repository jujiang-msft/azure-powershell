### Example 1: Checks that the Test Base Package name and version
```powershell
PS C:\> Test-AzTestBasePackageName -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg" -ApplicationName "package2_kaifa" -Name "package2_kaifa-1.0." -Type "package" -Version "1.0" 

Message                                                       NameAvailable Reason
-------                                                       ------------- ------
ApplicationName: package2_kaifa, Version: 1.0 already exists. False         AlreadyExists

```

Checks that the Test Base Package name and version is valid and is not already in use.

### Example 2: Checks that the Test Base Package name and version
```powershell
PS C:\> Test-AzTestBasePackageName -AccountName <String> -ResourceGroupName <String> -Parameter <IPackageCheckNameAvailabilityParameters> 

{{ Add output here }}
```

Checks that the Test Base Package name and version is valid and is not already in use.

