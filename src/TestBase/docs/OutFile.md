#### Name :Get-AzTestBaseAccount

#### Syntax:

- List (Default)
```Powershell
Get-AzTestBaseAccount [-SubscriptionId <String[]>] [-GetDeleted] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

- Get
```Powershell
Get-AzTestBaseAccount -Name <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseAccount -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- List1
```Powershell
Get-AzTestBaseAccount -ResourceGroupName <String> [-SubscriptionId <String[]>] [-GetDeleted]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBaseAnalysisResult

#### Syntax:

- Get (Default)
```Powershell
Get-AzTestBaseAnalysisResult -AccountName <String> -Name <AnalysisResultName> -PackageName <String>
 -ResourceGroupName <String> -TestResultName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseAnalysisResult -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

- List
```Powershell
Get-AzTestBaseAnalysisResult -AccountName <String> -PackageName <String> -ResourceGroupName <String>
 -TestResultName <String> -AnalysisResultType <AnalysisResultType> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBaseAvailableOS

#### Syntax:

- Get (Default)
```Powershell
Get-AzTestBaseAvailableOS -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseAvailableOS -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- List
```Powershell
Get-AzTestBaseAvailableOS -AccountName <String> -ResourceGroupName <String> -OSUpdateType <OSUpdateType>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBaseCustomerEvent

#### Syntax:

- List (Default)
```Powershell
Get-AzTestBaseCustomerEvent -AccountName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- Get
```Powershell
Get-AzTestBaseCustomerEvent -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseCustomerEvent -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBaseEmailEvent

#### Syntax:

- List (Default)
```Powershell
Get-AzTestBaseEmailEvent -AccountName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- Get
```Powershell
Get-AzTestBaseEmailEvent -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseEmailEvent -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBaseFavoriteProcess

#### Syntax:

- List (Default)
```Powershell
Get-AzTestBaseFavoriteProcess -AccountName <String> -PackageName <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- Get
```Powershell
Get-AzTestBaseFavoriteProcess -AccountName <String> -Name <String> -PackageName <String>
 -ResourceGroupName <String> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseFavoriteProcess -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

#### Name :Get-AzTestBaseFlightingRing

#### Syntax:

- List (Default)
```Powershell
Get-AzTestBaseFlightingRing -AccountName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- Get
```Powershell
Get-AzTestBaseFlightingRing -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseFlightingRing -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBaseOSUpdate

#### Syntax:

- Get (Default)
```Powershell
Get-AzTestBaseOSUpdate -AccountName <String> -Name <String> -PackageName <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseOSUpdate -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- List
```Powershell
Get-AzTestBaseOSUpdate -AccountName <String> -PackageName <String> -ResourceGroupName <String>
 -OSUpdateType <OSUpdateType> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBasePackage

#### Syntax:

- List (Default)
```Powershell
Get-AzTestBasePackage -AccountName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- Get
```Powershell
Get-AzTestBasePackage -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBasePackage -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBasePackageBlobPath

#### Syntax:

- GetExpanded (Default)
```Powershell
Get-AzTestBasePackageBlobPath -AccountName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-FileName <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

- Get
```Powershell
Get-AzTestBasePackageBlobPath -AccountName <String> -ResourceGroupName <String>
 -Parameter <IGetFileUploadUrlParameters> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBasePackageBlobPath -InputObject <ITestBaseIdentity> -Parameter <IGetFileUploadUrlParameters>
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

- GetViaIdentityExpanded
```Powershell
Get-AzTestBasePackageBlobPath -InputObject <ITestBaseIdentity> [-FileName <String>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :Get-AzTestBasePackageDownloadUrl

#### Syntax:

- Get (Default)
```Powershell
Get-AzTestBasePackageDownloadUrl -AccountName <String> -PackageName <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBasePackageDownloadUrl -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

#### Name :Get-AzTestBaseSku

#### Syntax:

```Powershell
Get-AzTestBaseSku [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBaseTestResult

#### Syntax:

- Get (Default)
```Powershell
Get-AzTestBaseTestResult -AccountName <String> -Name <String> -PackageName <String>
 -ResourceGroupName <String> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseTestResult -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- List
```Powershell
Get-AzTestBaseTestResult -AccountName <String> -PackageName <String> -ResourceGroupName <String>
 -OSUpdateType <OSUpdateType> [-SubscriptionId <String[]>] [-Filter <String>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

#### Name :Get-AzTestBaseTestResultDownloadUrl

#### Syntax:

- Get (Default)
```Powershell
Get-AzTestBaseTestResultDownloadUrl -AccountName <String> -PackageName <String> -ResourceGroupName <String>
 -TestResultName <String> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseTestResultDownloadUrl -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

#### Name :Get-AzTestBaseTestResultVideoDownloadUrl

#### Syntax:

- Get (Default)
```Powershell
Get-AzTestBaseTestResultVideoDownloadUrl -AccountName <String> -PackageName <String>
 -ResourceGroupName <String> -TestResultName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseTestResultVideoDownloadUrl -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :Get-AzTestBaseTestSummary

#### Syntax:

- List (Default)
```Powershell
Get-AzTestBaseTestSummary -AccountName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- Get
```Powershell
Get-AzTestBaseTestSummary -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseTestSummary -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBaseTestType

#### Syntax:

- List (Default)
```Powershell
Get-AzTestBaseTestType -AccountName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- Get
```Powershell
Get-AzTestBaseTestType -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

- GetViaIdentity
```Powershell
Get-AzTestBaseTestType -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :Get-AzTestBaseUsage

#### Syntax:

```Powershell
Get-AzTestBaseUsage -AccountName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-Filter <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

#### Name :New-AzTestBaseAccount

#### Syntax:

```Powershell
New-AzTestBaseAccount -Name <String> -ResourceGroupName <String> -Location <String> [-SubscriptionId <String>]
 [-Restore] [-SkuLocation <String[]>] [-SkuName <String>] [-SkuResourceType <String>] [-Tag <Hashtable>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :New-AzTestBaseCustomerEvent

#### Syntax:

```Powershell
New-AzTestBaseCustomerEvent -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] [-EventName <String>] [-Receiver <INotificationEventReceiver[]>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :New-AzTestBaseFavoriteProcess

#### Syntax:

```Powershell
New-AzTestBaseFavoriteProcess -AccountName <String> -PackageName <String> -ResourceGroupName <String>
 -ResourceName <String> [-SubscriptionId <String>] [-ActualProcessName <String>] [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :New-AzTestBasePackage

#### Syntax:

```Powershell
New-AzTestBasePackage -AccountName <String> -Name <String> -ResourceGroupName <String> -Location <String>
 [-SubscriptionId <String>] [-ApplicationName <String>] [-BlobPath <String>] [-FlightingRing <String>]
 [-Tag <Hashtable>] [-TargetOSList <ITargetOSInfo[]>] [-Test <ITest[]>] [-Version <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :Remove-AzTestBaseAccount

#### Syntax:

- Offboard (Default)
```Powershell
Remove-AzTestBaseAccount -AccountName <String> -ResourceGroupName <String> [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

- OffboardViaIdentity
```Powershell
Remove-AzTestBaseAccount -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :Remove-AzTestBaseCustomerEvent

#### Syntax:

- Delete (Default)
```Powershell
Remove-AzTestBaseCustomerEvent -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

- DeleteViaIdentity
```Powershell
Remove-AzTestBaseCustomerEvent -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [-AsJob]
 [-NoWait] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :Remove-AzTestBaseFavoriteProcess

#### Syntax:

- Delete (Default)
```Powershell
Remove-AzTestBaseFavoriteProcess -AccountName <String> -PackageName <String> -ResourceGroupName <String>
 -ResourceName <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

- DeleteViaIdentity
```Powershell
Remove-AzTestBaseFavoriteProcess -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :Remove-AzTestBasePackage

#### Syntax:

- Delete1 (Default)
```Powershell
Remove-AzTestBasePackage -AccountName <String> -PackageName <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

- DeleteViaIdentity1
```Powershell
Remove-AzTestBasePackage -InputObject <ITestBaseIdentity> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :Test-AzTestBasePackageName

#### Syntax:

- CheckExpanded (Default)
```Powershell
Test-AzTestBasePackageName -AccountName <String> -ResourceGroupName <String> -ApplicationName <String>
 -Name <String> -Type <String> -Version <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

- Check
```Powershell
Test-AzTestBasePackageName -AccountName <String> -ResourceGroupName <String>
 -Parameter <IPackageCheckNameAvailabilityParameters> [-SubscriptionId <String>] [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

- CheckViaIdentity
```Powershell
Test-AzTestBasePackageName -InputObject <ITestBaseIdentity>
 -Parameter <IPackageCheckNameAvailabilityParameters> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

- CheckViaIdentityExpanded
```Powershell
Test-AzTestBasePackageName -InputObject <ITestBaseIdentity> -ApplicationName <String> -Name <String>
 -Type <String> -Version <String> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

#### Name :Update-AzTestBaseAccount

#### Syntax:

- UpdateExpanded (Default)
```Powershell
Update-AzTestBaseAccount -Name <String> -ResourceGroupName <String> [-SubscriptionId <String>]
 [-SkuLocation <String[]>] [-SkuName <String>] [-SkuResourceType <String>] [-Tag <Hashtable>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

- UpdateViaIdentityExpanded
```Powershell
Update-AzTestBaseAccount -InputObject <ITestBaseIdentity> [-SkuLocation <String[]>] [-SkuName <String>]
 [-SkuResourceType <String>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

#### Name :Update-AzTestBasePackage

#### Syntax:

- UpdateExpanded (Default)
```Powershell
Update-AzTestBasePackage -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] [-BlobPath <String>] [-FlightingRing <String>] [-IsEnabled] [-Tag <Hashtable>]
 [-TargetOSList <ITargetOSInfo[]>] [-Test <ITest[]>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

- UpdateViaIdentityExpanded
```Powershell
Update-AzTestBasePackage -InputObject <ITestBaseIdentity> [-BlobPath <String>] [-FlightingRing <String>]
 [-IsEnabled] [-Tag <Hashtable>] [-TargetOSList <ITargetOSInfo[]>] [-Test <ITest[]>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```


