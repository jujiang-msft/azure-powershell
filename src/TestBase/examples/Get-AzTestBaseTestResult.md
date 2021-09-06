### Example 1: Get the Test Result by Id with specified OS Update type for a Test Base Package
```powershell
PS C:\> Get-AzTestBaseTestResult -AccountName "testBaseAccount_kaifa" -Name "TestResult-eb31eaf8-cfa7-4595-a96a-05c38c3db51f" -PackageName "package2_kaifa-1.0"  -ResourceGroupName "testbase_rg"

Name                                            Type
----                                            ----
TestResult-eb31eaf8-cfa7-4595-a96a-05c38c3db51f testBaseAccounts/packages/testResults

```

Get the Test Result by Id with specified OS Update type for a Test Base Package.

### Example 2: Get a List of TestResults
```powershell
PS C:\> Get-AzTestBaseTestResult -AccountName "testBaseAccount_kaifa" -PackageName "package2_kaifa-1.0"  -ResourceGroupName "testbase_rg" -OSUpdateType "SecurityUpdate" -Filter "osName eq 'Windows 10 21H1' and releaseName eq '2021.05 B' and buildRevision eq '985'"

Name                                            Type
----                                            ----
TestResult-eb31eaf8-cfa7-4595-a96a-05c38c3db51f testBaseAccounts/packages/testResults
TestResult-8ea496b3-04bf-4a3d-a370-87d12c22a333 testBaseAccounts/packages/testResults
TestResult-a1aef2a4-ec4d-4025-8fbd-576dcb96c5fe testBaseAccounts/packages/testResults
TestResult-57e020e4-f981-44e6-ae7a-627709faad0f testBaseAccounts/packages/testResults
TestResult-b4d6daff-72df-4efe-901d-c5b7712bbae2 testBaseAccounts/packages/testResults
TestResult-3322317d-894a-458e-a340-1d5704fdb342 testBaseAccounts/packages/testResults
TestResult-976abb8b-32cb-4a17-bf75-b7323c9341e6 testBaseAccounts/packages/testResults
TestResult-c4fea270-8c43-4ac6-9e5b-90801050c77d testBaseAccounts/packages/testResults
TestResult-4e8f74ae-8448-4d17-88eb-d00740218de8 testBaseAccounts/packages/testResults
TestResult-86763fc2-04fc-443d-b172-be6e4f2b236f testBaseAccounts/packages/testResults
TestResult-13b5e5f4-8370-4715-a74e-322e5f321044 testBaseAccounts/packages/testResults

```

Get a List of TestResults.

