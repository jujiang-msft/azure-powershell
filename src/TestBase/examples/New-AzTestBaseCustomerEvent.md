### Example 1: Create or replace a Test Base Customer Event
```powershell
PS C:\> $userObjId=@("test1","test2")   
PS C:\> $receiver=${ReceiverType="UserObjects";ReceiverValueUserObjectReceiverValue=$userObjId}
PS C:\> New-AzTestBaseCustomerEvent -AccountName "testBaseAccount_kaifa" -Name "testbase0908_event" -ResourceGroupName "testbase_rg" -Receiver $receiver -EventName "initial-verification" 

{{ Add output here }}
```

Create or replace a Test Base Customer Event.

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

