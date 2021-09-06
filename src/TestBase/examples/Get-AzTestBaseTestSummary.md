### Example 1: Gets a Test Summary with specific name from all the Test Summaries of all the packages under a Test Base Account
```powershell
PS C:\> Get-AzTestBaseTestSummary -AccountName "testBaseAccount_kaifa" -Name "TestSummary-fd550cae-fe50-3cd9-bf95-4e51be898883" -ResourceGroupName "testbase_rg"

Name                                             Type
----                                             ----
TestSummary-fd550cae-fe50-3cd9-bf95-4e51be898883 testBaseAccounts/testSummaries

```

Gets a Test Summary with specific name from all the Test Summaries of all the packages under a Test Base Account.

### Example 2: Get a List of Test Summaries
```powershell
PS C:\> Get-AzTestBaseTestSummary -AccountName "testBaseAccount_kaifa" -ResourceGroupName "testbase_rg"

Name                                             Type
----                                             ----
TestSummary-fd550cae-fe50-3cd9-bf95-4e51be898883 testBaseAccounts/testSummaries
TestSummary-4866691c-7ee5-39ea-b855-32b18a7109f8 testBaseAccounts/testSummaries
TestSummary-b1632872-0e1a-3c3f-bac1-f525a0af60bf testBaseAccounts/testSummaries
TestSummary-ed33d860-b9c1-3762-9f82-4884ce33544b testBaseAccounts/testSummaries
TestSummary-3a0d34ab-b417-3938-97af-d4983e3b51ea testBaseAccounts/testSummaries
TestSummary-0b6dcd10-4855-351e-a2ff-308fd9d4bcd0 testBaseAccounts/testSummaries
TestSummary-243117f3-5234-36a5-9fa1-441c1b8740f7 testBaseAccounts/testSummaries

```

Get a List of Test Summaries.

