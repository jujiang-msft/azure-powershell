### Example 1: Update an existing Test Base Account
```powershell
PS C:\> Update-AzTestBaseAccount -Name "TESTBASEACCOUNT_KAIFA" -ResourceGroupName "testbase_rg"  -Tag @{test="test0906"}

Etag Location Name                  Type                                AzureAsyncOperation
---- -------- ----                  ----                                -------------------
     global   TESTBASEACCOUNT_KAIFA microsoft.testbase/testbaseaccounts

```

Update an existing Test Base Account.

### Example 2: Update an existing Test Base Account
```powershell
PS C:\> Update-AzTestBaseAccount -InputObject <ITestBaseIdentity>

{{ Add output here }}
```

Update an existing Test Base Account.

