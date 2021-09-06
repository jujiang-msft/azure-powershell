### Example 1: Gets a Test Base CustomerEvent
```powershell
PS C:\> Get-AzTestBaseCustomerEvent -AccountName "testBaseAccount_kaifa" -Name "testbase6336_event" -ResourceGroupName "testbase_rg"  

Name               Type AzureAsyncOperation
----               ---- -------------------
testbase6336_event

```

Gets a Test Base CustomerEvent.

### Example 2: Get a List of CustomerEvents
```powershell
PS C:\> Get-AzTestBaseCustomerEvent -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg" 

Name                Type AzureAsyncOperation
----                ---- -------------------
testbase6336_event
testbase2303_event
testbase9379_event
testbase2062_event
testbase5139_event
testbase3963_event
testbase1499_event
testbase9406_event
testbase5219_event
InitialVerification

```

Get a List of CustomerEvents.

