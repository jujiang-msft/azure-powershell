### Example 1: Get a list of TestBaseAccounts
```powershell
PS C:\> Get-AzTestBaseAccount -SubscriptionId "9fabf001-9c1f-4aab-9451-e431da271956" 

Etag Location Name                               Type                                AzureAsyncOperation
---- -------- ----                               ----                                -------------------
     global   E2ESmokeTest                       microsoft.testbase/testbaseaccounts
     global   revise-001                         microsoft.testbase/testbaseaccounts
     global   jujiang-tb04121227                 microsoft.testbase/testbaseaccounts
     global   kezy-tb                            microsoft.testbase/testbaseaccounts
     global   test-001                           microsoft.testbase/testbaseaccounts
     global   jujiang-tb-04191937                microsoft.testbase/testbaseaccounts
     global   test123                            microsoft.testbase/testbaseaccounts
     global   e2eSmokeTest_22042021              microsoft.testbase/testbaseaccounts
     global   test app                           microsoft.testbase/testbaseaccounts
     global   My Testbase Account 2              microsoft.testbase/testbaseaccounts
     global   srpnt                              microsoft.testbase/testbaseaccounts
……

```

Obtain the TestBaseAccount list based on the subscriptionID, and use the getDeleted parameter to control whether to obtain deleted accounts.

### Example 2: Get a TestBaseAccount
```powershell
PS C:\> Get-AzTestBaseAccount -Name "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg"

Etag Location Name                  Type                                AzureAsyncOperation
---- -------- ----                  ----                                -------------------
     global   TESTBASEACCOUNT_KAIFA microsoft.testbase/testbaseaccounts

```

Obtain TestBaseAccount from TestBaseAccountName and ResourceGroupName.

