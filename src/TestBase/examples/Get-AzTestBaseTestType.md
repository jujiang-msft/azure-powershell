### Example 1: Gets a test type of a Test Base Account
```powershell
PS C:\> Get-AzTestBaseTestType -AccountName "testBaseAccount_kaifa" -Name "Out-of-Box-Test" -ResourceGroupName "testbase_rg"

Name            Type
----            ----
Out-of-Box-Test

```

Gets a test type of a Test Base Account.

### Example 2: Get a List of TestTypes
```powershell
PS C:\> Get-AzTestBaseTestType -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg"

Name            Type
----            ----
Out-of-Box-Test
Functional-Test

```

Get a List of TestTypes.

