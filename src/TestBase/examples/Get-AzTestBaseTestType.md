### Example 1: Gets a test type of a Test Base Account
```powershell
PS C:\> Get-AzTestBaseTestType -AccountName "ContosoAccount" -Name "Out-of-Box-Test" -ResourceGroupName "ContosoRG"

Name            Type
----            ----
Out-of-Box-Test

```

Gets a test type of a Test Base Account.

### Example 2: Get a List of TestTypes
```powershell
PS C:\> Get-AzTestBaseTestType -AccountName "ContosoAccount" -ResourceGroupName "ContosoRG"

Name            Type
----            ----
Out-of-Box-Test
Functional-Test

```

Get a List of TestTypes.

