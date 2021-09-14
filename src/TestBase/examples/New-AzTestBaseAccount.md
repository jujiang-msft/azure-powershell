### Example 1: Create or replace (overwrite/recreate, with potential downtime) a Test Base Account in the specified subscription
```powershell
PS C:\> New-AzTestBaseAccount -Name "ContosoAccount" -ResourceGroupName "ContosoRG" -Location "Global" -SkuLocation "Global" -SkuName "S0" -Tag @{test="test"}

Etag Location Name             Type                                AzureAsyncOperation
---- -------- ----             ----                                -------------------
     Global   ContosoAccount   microsoft.testbase/testbaseaccounts

```

Create or replace (overwrite/recreate, with potential downtime) a Test Base Account in the specified subscription.

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

