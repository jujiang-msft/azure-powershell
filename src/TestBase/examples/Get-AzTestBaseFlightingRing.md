### Example 1: Gets a flighting ring of a Test Base Account
```powershell
PS C:\> Get-AzTestBaseFlightingRing -AccountName "testBaseAccount_kaifa" -Name "Insider-Beta-Channel" -ResourceGroupName "testbase_rg"

Name                 Type
----                 ----
Insider-Beta-Channel

```

Gets a flighting ring of a Test Base Account

### Example 2: Get a List of FlightingRings
```powershell
PS C:\> Get-AzTestBaseFlightingRing -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg" 

Name                 Type
----                 ----
Insider-Beta-Channel

```

Get a List of FlightingRings.

