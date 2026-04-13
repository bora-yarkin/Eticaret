<!--
SPDX-FileCopyrightText: 2026 Bora Yarkın
SPDX-License-Identifier: GPL-3.0-only
-->

# Contributing

Thanks for helping improve Eticaret.

## Before You Start

- Read the [Code of Conduct](CODE_OF_CONDUCT.md).
- Check existing issues and pull requests before starting overlapping work.
- Keep changes focused. Small, reviewable pull requests are preferred.

## Local Setup

```bash
dotnet restore Eticaret/Eticaret.sln
dotnet build Eticaret/Eticaret.sln
dotnet test Eticaret/Eticaret.WebUI.Tests/Eticaret.WebUI.Tests.csproj
```

## Pull Requests

- Describe the problem and the approach clearly.
- Include screenshots when UI behavior changes.
- Add or update tests when behavior changes.
- Update documentation when setup, behavior, or contributor expectations change.
- Keep SPDX notices intact. New project-owned files should use `GPL-3.0-only` with `2026 Bora Yarkın` copyright metadata.

## Dependencies And Vendored Assets

- Do not replace or relicense bundled third-party assets without preserving their upstream notices.
- Security-sensitive dependency updates should mention risk and compatibility impact in the pull request.
