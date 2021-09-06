### Example 1: Gets an OS Update by name in which the package was tested before
```powershell
PS C:\> Get-AzTestBaseOSUpdate -AccountName "testBaseAccount_kaifa" -Name "TestResultOs-fa69193f-9220-37f0-85af-f28b9f7ccc0c" -PackageName "package2_kaifa-1.0" -ResourceGroupName "testbase_rg"

Name                                              Type
----                                              ----
TestResultOs-fa69193f-9220-37f0-85af-f28b9f7ccc0c testBaseAccounts/packages/osUpdates

```

Gets an OS Update by name in which the package was tested before.

### Example 2: Get a List of OSUpdates
```powershell
PS C:\> Get-AzTestBaseOSUpdate -AccountName "testBaseAccount_kaifa" -PackageName "package2_kaifa-1.0" -ResourceGroupName "testbase_rg" -OSUpdateType "SecurityUpdate"

Name                                              Type
----                                              ----
TestResultOs-fa69193f-9220-37f0-85af-f28b9f7ccc0c testBaseAccounts/packages/osUpdates
TestResultOs-9763e0f2-9096-31ac-a7f8-490d8f2221bd testBaseAccounts/packages/osUpdates
TestResultOs-5f0f758e-7903-39b5-96f5-ceac7d2d98bd testBaseAccounts/packages/osUpdates
TestResultOs-2a2259e1-1e3d-385a-98cb-1a5f58855965 testBaseAccounts/packages/osUpdates
TestResultOs-2197ce80-b449-389b-8152-14b19c0d5dae testBaseAccounts/packages/osUpdates
TestResultOs-e54f2bbc-f56a-314e-a537-16a1ba309538 testBaseAccounts/packages/osUpdates
TestResultOs-ae7e4943-ebf8-326b-af59-d4be698fc11b testBaseAccounts/packages/osUpdates
TestResultOs-9038d1ef-f242-3323-b11b-b4d1969c8d01 testBaseAccounts/packages/osUpdates
TestResultOs-01103ae1-157f-371b-b9f6-229b877e0513 testBaseAccounts/packages/osUpdates
TestResultOs-a8fc4116-4bb7-36c2-85c5-d62ce5eb38cb testBaseAccounts/packages/osUpdates
TestResultOs-da77ac82-55c9-3392-b489-b6f7eb73b094 testBaseAccounts/packages/osUpdates
TestResultOs-37e66749-fcd5-3aec-a5fd-ca225721ebc6 testBaseAccounts/packages/osUpdates
TestResultOs-05b30164-9e2c-3508-83fe-8966e2b9110d testBaseAccounts/packages/osUpdates
TestResultOs-6798bc17-d5d2-3517-a114-5291e57c0bba testBaseAccounts/packages/osUpdates
TestResultOs-e18d26b5-c4a2-3af6-806f-a6b68423bbaa testBaseAccounts/packages/osUpdates

```

Get a List of OSUpdates.

