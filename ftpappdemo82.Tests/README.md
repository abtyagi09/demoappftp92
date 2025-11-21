# ftpappdemo82.Tests

This project contains unit tests for the ftpappdemo82 ASP.NET Web Forms application.

## Test Framework

- **xUnit**: Testing framework
- **Target Framework**: .NET Framework 4.7.2
- **Dependencies**: Moq for mocking

## Running Tests

### Using .NET CLI

```bash
dotnet test
```

### Using Visual Studio

1. Open the solution in Visual Studio
2. Build the solution
3. Open Test Explorer (Test > Test Explorer)
4. Click "Run All" to execute all tests

### Using Visual Studio Code

1. Install the .NET Core Test Explorer extension
2. Open the solution folder
3. Tests will appear in the Test Explorer panel
4. Click the run button to execute tests

## Test Coverage

The test suite includes tests for:

- **BundleConfig**: Tests for script bundle configuration
- **RouteConfig**: Tests for friendly URL routing configuration  
- **Global**: Tests for application startup and initialization
- **Pages**: Tests for Default, About, and Contact pages

## Notes

- Tests are designed to work cross-platform (Windows, Linux, macOS)
- Some platform-specific issues with ScriptResourceMapping on Mono/Linux are handled gracefully
- All tests should pass on both Windows (.NET Framework) and Linux/macOS (Mono)
