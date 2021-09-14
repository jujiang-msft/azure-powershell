### Example 1: Gets a Test Base CustomerEvent
```powershell
PS C:\> Get-AzTestBaseCustomerEvent -AccountName "ContosoAccount" -Name "ContosoAlert" -ResourceGroupName "ContosoRG"  

Name               Type AzureAsyncOperation
----               ---- -------------------
ContosoAlert

```

Gets a Test Base CustomerEvent.

### Example 2: Get a List of CustomerEvents
```powershell
PS C:\> Get-AzTestBaseCustomerEvent -AccountName "ContosoAccount" -ResourceGroupName "ContosoRG" 

Name                Type AzureAsyncOperation
----                ---- -------------------
ContosoAlert
……
InitialVerification

```

Get a List of CustomerEvents.

