# Tennis Kata

A Tennis Kata implementation in C# using Test-Driven Development .

This project implements the rules of tennis scoring, as specified in https://codingdojo.org/kata/Tennis/ .

---

# Technologies

- C#
- .NET 10
- xUnit

---

# Project Structure

```text
TennisKata/
├── TennisKata/
│   ├── TennisKata.cs
│   └── TennisKata.csproj
│
├── TennisKata.Tests/
│   ├── Tests.cs
│   └── TennisKata.Tests.csproj
```

---

# Running the Tests

From the repository root:

```bash
dotnet test TennisKata.Tests/TennisKata.Tests.csproj
```

---

# TDD Approach

The project was developed incrementally using TDD:

1. Write a failing test
2. Implement the minimum code required
3. Refactor
4. Repeat

---
