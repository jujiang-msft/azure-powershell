### Example 1: Gets an available OS to run a package under a Test Base Account.
```powershell
PS C:\> Get-AzTestBaseAvailableOS -AccountName "testBaseAccount_kaifa" -Name "Windows-10-21H1-FeatureUpdate" -ResourceGroupName "testbase_rg"

Name                          Type
----                          ----
Windows-10-21H1-FeatureUpdate

```

Gets an available OS to run a package under a Test Base Account.

### Example 2: Get a List of AvailableOSs
```powershell
PS C:\> Get-AzTestBaseAvailableOS -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg" -OSUpdateType "SecurityUpdate"

Name                                            Type
----                                            ----
Windows-10-21H2-FeatureUpdate
Windows-10-21H1-FeatureUpdate
Windows-10-20H2-FeatureUpdate
Windows-10-2004-FeatureUpdate
Windows-10-1903-FeatureUpdate
Windows-Server-2022-WindowsUpdate
Windows-Server-2019---Server-Core-WindowsUpdate
Windows-Server-2019-WindowsUpdate
Windows-Server-2016---Server-Core-WindowsUpdate
Windows-Server-2016-WindowsUpdate
Windows-7.0-SP1-WindowsUpdate
Windows-11-21H2-WindowsUpdate
Windows-10-21H1-WindowsUpdate
Windows-10-20H2-WindowsUpdate
Windows-10-2004-WindowsUpdate
Windows-10-1909-WindowsUpdate
All-Future-OS-Updates-WindowsUpdate
```
Get a List of AvailableOSs under a Test Base Account.

