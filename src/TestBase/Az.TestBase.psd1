@{
  GUID = '18ceda02-c000-459d-8290-b99635c6a4ee'
  RootModule = './Az.TestBase.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: TestBase cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.TestBase.private.dll'
  FormatsToProcess = './Az.TestBase.format.ps1xml'
  FunctionsToExport = 'Get-AzTestBaseAccount', 'Get-AzTestBaseAnalysisResult', 'Get-AzTestBaseAvailableOS', 'Get-AzTestBaseCustomerEvent', 'Get-AzTestBaseEmailEvent', 'Get-AzTestBaseFavoriteProcess', 'Get-AzTestBaseFlightingRing', 'Get-AzTestBaseOSUpdate', 'Get-AzTestBasePackage', 'Get-AzTestBasePackageBlobPath', 'Get-AzTestBasePackageDownloadUrl', 'Get-AzTestBaseSku', 'Get-AzTestBaseTestResult', 'Get-AzTestBaseTestResultDownloadUrl', 'Get-AzTestBaseTestResultVideoDownloadUrl', 'Get-AzTestBaseTestSummary', 'Get-AzTestBaseTestType', 'Get-AzTestBaseUsage', 'New-AzTestBaseAccount', 'New-AzTestBaseCustomerEvent', 'New-AzTestBaseFavoriteProcess', 'New-AzTestBasePackage', 'Remove-AzTestBaseAccount', 'Remove-AzTestBaseCustomerEvent', 'Remove-AzTestBaseFavoriteProcess', 'Remove-AzTestBasePackage', 'Test-AzTestBasePackageName', 'Update-AzTestBaseAccount', 'Update-AzTestBasePackage', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'TestBase'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
