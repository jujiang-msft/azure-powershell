### Example 1: Create or replace (overwrite/recreate, with potential downtime) a Test Base Account in the specified subscription
```powershell
PS C:\> New-AzTestBaseAccount -Name "testBaseAccount0902_test" -ResourceGroupName "testbase_rg" -Location "Global" -SkuLocation "Global" -SkuName "S0" -Tag @{test="test"}

Etag Location Name                     Type                                AzureAsyncOperation
---- -------- ----                     ----                                -------------------
     Global   testBaseAccount0902_test microsoft.testbase/testbaseaccounts

```

Create or replace (overwrite/recreate, with potential downtime) a Test Base Account in the specified subscription.

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

