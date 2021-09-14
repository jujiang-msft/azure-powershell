### Example 1: Gets a email event of a Test Base Account
```powershell
PS C:\> Get-AzTestBaseEmailEvent -AccountName "ContosoAccount" -Name "InitialVerification" -ResourceGroupName "ContosoRG"

Name                Type
----                ----
InitialVerification

```

Gets a email event of a Test Base Account.

### Example 2: Get a List of EmailEvents
```powershell
PS C:\> Get-AzTestBaseEmailEvent -AccountName "ContosoAccount" -ResourceGroupName "ContosoRG"

Name                Type
----                ----
InitialVerification
TestFailures
FreeHourUsage

```

Get a List of EmailEvents.

