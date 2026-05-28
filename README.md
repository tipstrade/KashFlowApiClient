# KashFlowApiClient [![NuGet](https://img.shields.io/nuget/v/KashFlowApiClient.svg)](https://www.nuget.org/packages/KashFlowApiClient/)

A .NET wrapper for the KashFlow SOAP API.

Versioning
- As of version 8.x the package major version follows the .NET target version (e.g. 8.x.x targets net8.0).

Supported target frameworks
- net8.0
- net481 (for compatibility with older projects, but not recommended for new development)

## Change log

### 8.0.0
- Bumped major version to align with .NET target version (net8.0)

### 4.0.2.0
- Removed dependency for System.Linq.Async
- Add support for CancellationToken in all async methods.
- Target net8.0
- Add support for the REST API (V2)
- Breaking Changes: Update namespace to TipsTrade.KashFlowApi

--- 

### Documentation
- [SOAP API Documentation](https://www.kashflow.com/developers/soap-api/)
- [Web service definition](https://securedwebapp.com/api/service.asmx)
- [V2 REST API Documentation (beta)](https://www.kashflow.com/developers/rest-api/integrations/)
