### Example 1: Deletes a Test Base Customer Event
```powershell
PS C:\> Remove-AzTestBaseCustomerEvent -AccountName "testBaseAccount_kaifa" -Name "TestBaseCustomerEvent3103" -ResourceGroupName "testbase_rg"

{{ Add output here }}
```

Deletes a Test Base Customer Event.

### Example 2: Deletes a Test Base Customer Event
```powershell
PS C:\> $inputObjs=@{SubscriptionId="9fabf001-9c1f-4aab-9451-e431da271956";ResourceGroupName="testbase_rg";TestBaseAccountName="testBaseAccount_kaifa";CustomerEventName="TestBaseCustomerEvent3103"}
Remove-AzTestBaseCustomerEvent -InputObject $inputObjs

{{ Add output here }}
```

Deletes a Test Base Customer Event.

