### Example 1: Create or replace (overwrite/recreate, with potential downtime) a Test Base Package
```powershell
PS C:\> $osInfoFeature=${OSUpdateType="Feature updates";TargetOSs=@("Windows 10 20H2")}
$osInfoSecurity=${OSUpdateType="Security updates";TargetOSs=@("Windows 10 21H1","Windows 10 20H2")}
$commandInstall=${Name="install";Action="Install";ContentType="Path";Content="test/scripts/install/job.ps1";RunElevated=False;RestartAfter=True;MaxRunTime=1800;RunAsInteractive=True;AlwaysRun=True;ApplyUpdateBefore=False}
$commandLaunch=${Name="launch";Action="Launch";ContentType="Path";Content="test/scripts/launch/job.ps1";RunElevated=True;RestartAfter=False;MaxRunTime=1800;RunAsInteractive=True;AlwaysRun=False;ApplyUpdateBefore=True}
$commandClose=${Name="close";Action="Close";ContentType="Path";Content="test/scripts/close/job.ps1";RunElevated=True;RestartAfter=False;MaxRunTime=1800;RunAsInteractive=True;AlwaysRun=False;ApplyUpdateBefore=False}
$commandUninstall=${Name="uninstall";Action="Uninstall";ContentType="Path";Content="test/scripts/uninstall/job.ps1";RunElevated=True;RestartAfter=False;MaxRunTime=1800;RunAsInteractive=True;AlwaysRun=True;ApplyUpdateBefore=False}
New-AzTestBasePackage -AccountName "testBaseAccount_kaifa" -Name "Package0908-1.0.0" -ResourceGroupName "testbase_rg" -Location "global" -ApplicationName "Package0908" -BlobPath "https://tbwestusppesa.blob.core.windows.net/c0097881-16f2-4c2a-b6f1-1e2c7d7cb8e7/temp/b000407a-c56f-403b-9f2a-b83ac2db17e2/test.zip" -FlightingRing "Insider Beta Channel" -Tag @{test="test"} -Version "1.0.0" -TargetOSList @($osInfoFeature,$osInfoSecurity) -Test ${IsActive=True;TestType="OutOfBoxTest";Command=@($commandInstall,$commandLaunch,$commandClose,$commandUninstall)}

{{ Add output here }}
```

Create or replace (overwrite/recreate, with potential downtime) a Test Base Package.

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

