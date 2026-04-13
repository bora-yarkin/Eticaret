<!--
SPDX-FileCopyrightText: 2026 Bora Yarkın
SPDX-License-Identifier: GPL-3.0-only
-->

# Eticaret

Bora Yarkın tarafından SmartPro Projesi için oluşturulan Web sitesi

A website created by Bora Yarkin for the SmartPro project.

## Overview

Eticaret is an ASP.NET Core MVC e-commerce sample application. The solution is split into domain, service, data access, web UI, and test projects.

## Solution Structure

- `Eticaret.Core`: domain models, contracts, and view models
- `Eticaret.Services`: basket and order business logic
- `Eticaret.DataAccess.SQL`: Entity Framework Core data access, SQL repository, and migrations
- `Eticaret.DataAccess.InMemory`: in-memory repository implementation
- `Eticaret.WebUI`: the ASP.NET Core MVC frontend application
- `Eticaret.WebUI.Tests`: MSTest-based test project

## Requirements

- .NET SDK `10.0.102` (or the latest patch allowed by `global.json`)
- Access to a SQL Server instance
- A valid `DefaultConnection` value in `Eticaret/Eticaret.WebUI/appsettings.json`

## Getting Started

1. Update the connection string in `Eticaret/Eticaret.WebUI/appsettings.json` for your SQL Server instance.
2. Restore the solution dependencies.
3. Run the web application.

```bash
dotnet restore Eticaret/Eticaret.sln
dotnet run --project Eticaret/Eticaret.WebUI/Eticaret.WebUI.csproj
```

The application applies pending Entity Framework Core migrations automatically during startup.

## Running Tests

```bash
dotnet test Eticaret/Eticaret.WebUI.Tests/Eticaret.WebUI.Tests.csproj
```

## Contributing

Contributions are welcome. Before opening a pull request, please review:

- [CONTRIBUTING.md](.github/CONTRIBUTING.md)
- [CODE_OF_CONDUCT.md](.github/CODE_OF_CONDUCT.md)
- [SECURITY.md](.github/SECURITY.md)

## License

Project-owned files in this repository are licensed under `GPL-3.0-only`. See [LICENSE](LICENSE) for the full GPLv3 text and [COPYRIGHT.md](COPYRIGHT.md) for bundled third-party notices.
