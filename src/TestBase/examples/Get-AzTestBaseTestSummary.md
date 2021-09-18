### Example 1: Gets a Test Summary with specific name from all the Test Summaries of all the packages under a Test Base Account
```powershell
PS C:\> Get-AzTestBaseTestSummary -AccountName "ContosoAccount" -Name "contoso-package2-096bffb5-5d3d-4305-a66a-953372ed6e88" -ResourceGroupName "ContosoRG"

Name                                                  Type
----                                                  ----
contoso-package2-096bffb5-5d3d-4305-a66a-953372ed6e88 testBaseAccounts/testSummaries

```

Gets a Test Summary with specific name from all the Test Summaries of all the packages under a Test Base Account.

### Example 2: Get a List of Test Summaries
```powershell
PS C:\> Get-AzTestBaseTestSummary -AccountName "ContosoAccount" -ResourceGroupName "ContosoRG"

Name                                                  Type
----                                                  ----
contoso-package2-096bffb5-5d3d-4305-a66a-953372ed6e88 testBaseAccounts/testSummaries

```

Get a List of Test Summaries.

