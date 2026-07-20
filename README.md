# CICD-Learning

A .NET console application for learning CI/CD practices.

## Requirements

- .NET 10 SDK
- Git

## Run

```bash
dotnet run --project src/CicdDemo -- "小呈"
```

## Local CI

```bash
dotnet restore
dotnet build --configuration Release --no-restore
dotnet test --configuration Release --no-build
```

## Project Structure

```bash
src/CicdDemo
tests/CicdDemo.Tests
.github/workflows
```

## CI/CD Workflow

GitHub Actions automatically restores dependencies, builds the solution, and runs automated tests for pushes and pull requests targeting main.

## Development Workflow

1. Create a feature branch from `main`.
2. Make and test changes locally.
3. Push the feature branch.
4. Open a pull request targeting `main`.
5. Wait for CI to pass.
6. Merge the pull request.
