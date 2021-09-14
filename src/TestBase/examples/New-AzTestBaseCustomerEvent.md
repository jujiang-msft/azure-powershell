### Example 1: Create or replace a Test Base Customer Event
```powershell
PS C:\> $userObjId=@("2d52b4d4-3a12-4230-b3c3-f68ca3bb272e")   
$receiver=@{ReceiverType="UserObjects";ReceiverValueUserObjectReceiverValue=$userObjId}
New-AzTestBaseCustomerEvent -AccountName "testBaseAccount_kaifa" -Name "testbase0914_event" -ResourceGroupName "testbase_rg" -Receiver $receiver -EventName "initial-verification"

{{ Add output here }}
```

Create or replace a Test Base Customer Event.

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

