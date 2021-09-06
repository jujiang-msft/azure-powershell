### Example 1: Gets the download URL of the test result
```powershell
PS C:\> Get-AzTestBaseTestResultDownloadUrl -AccountName "testBaseAccount_kaifa" -PackageName "package2_kaifa-1.0" -ResourceGroupName "testbase_rg" -TestResultName "TestResult-eb31eaf8-cfa7-4595-a96a-05c38c3db51f"

DownloadUrl
-----------
https://tbintelportalppe.blob.core.windows.net/zips/c0097881-16f2-4c2a-b6f1-1e2c7d7cb8e7/eb31eaf8-cfa7-4595-a96a-05c38c3db51f/logs.zip?sv=2019-02-02&sr=b&sig=rfp1ugddJ%2FXBQ7mlqXLmUHNJW7icvc8mbdCc%2B6pf9%2BY%3D&st=2021-08-30T07%3A09%3A…

```

Gets the download URL of the test result.

### Example 2: Gets the download URL of the test result
```powershell
PS C:\> Get-AzTestBaseTestResultDownloadUrl -InputObject <ITestBaseIdentity>

{{ Add output here }}
```

Gets the download URL of the test result.

