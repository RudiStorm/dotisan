# Dotisan – The Crafted Test Ecosystem for .NET

## 📖 Overview
Dotisan is a suite of **small, focused NuGet packages** for .NET developers, designed in the spirit of Sebastian Bergmann’s PHP ecosystem (PHPUnit + companions).  

Instead of monolithic frameworks, Dotisan provides **lego blocks** — sharp, reusable utilities that work independently but shine when combined.  

**Mission:**  
Help .NET developers write **faster, cleaner, and more reliable tests** by filling the gaps left by existing frameworks.

---

## 🧩 Philosophy
- **Small, composable packages** – each solves one problem well.  
- **Ecosystem cohesion** – common naming (`Dotisan.*`) and vision.  
- **Practical defaults** – minimal boilerplate, usable out of the box.  
- **Transparency** – no magic, just clean .NET code.  

---

## ⚡ Packages

### 1. Core
| Package              | Type       | Purpose |
|----------------------|------------|---------|
| `Dotisan.Unit`       | Class Lib  | Lightweight test runner (anchor project). |
| `Dotisan.Assert`     | Class Lib  | Fluent, human-readable assertions. |
| `Dotisan.Reporter`   | Class Lib  | Pluggable reporters (HTML, Markdown, JUnit). |

---

### 2. Coverage & Quality
| Package                   | Type       | Purpose |
|---------------------------|------------|---------|
| `Dotisan.Coverage`        | Class Lib  | Wrapper around Coverlet for simpler usage. |
| `Dotisan.CoverageReport`  | Tool       | Istanbul-style HTML dashboards. |
| `Dotisan.CoverageGuard`   | Middleware | CI gate: block when coverage < threshold. |

---

### 3. Mocks & Test Data
| Package            | Type        | Purpose |
|--------------------|-------------|---------|
| `Dotisan.Mock`     | SourceGen   | Micro mocking framework with generated mocks. |
| `Dotisan.Stub`     | Class Lib   | Helpers for fake/stub implementations. |
| `Dotisan.Faker`    | Class Lib   | Lightweight fake data generator. |
| `Dotisan.Factory`  | SourceGen   | Auto fixture / object factory generator. |

---

### 4. Test Infrastructure
| Package              | Type      | Purpose |
|----------------------|-----------|---------|
| `Dotisan.Timer`      | Class Lib | Measure test execution, report slowest cases. |
| `Dotisan.Sandbox`    | Class Lib | Ephemeral FS/DB/Redis for isolation. |
| `Dotisan.Parallel`   | Analyzer  | Detect unsafe parallel tests. |
| `Dotisan.Retry`      | Class Lib | Retry flaky tests with backoff. |
| `Dotisan.Golden`     | Class Lib | Snapshot & golden master testing. |

---

### 5. Integration Testing
| Package               | Type       | Purpose |
|-----------------------|------------|---------|
| `Dotisan.HttpMock`    | Class Lib  | Inline fake HTTP server. |
| `Dotisan.DbSnapshot`  | Tool       | Capture & restore DB state for tests. |
| `Dotisan.EventReplay` | Tool       | Intercept & replay Kafka/RabbitMQ events. |
| `Dotisan.ApiContract` | Template   | Scaffold contract tests. |
| `Dotisan.FeatureToggle` | Middleware | Run tests across feature-flag variations. |

---

### 6. Reporting & Insights
| Package              | Type      | Purpose |
|----------------------|-----------|---------|
| `Dotisan.Diff`       | Class Lib | Pretty diffs for JSON/XML/string comparisons. |
| `Dotisan.Trend`      | Tool      | Historical test trend dashboard. |
| `Dotisan.Artifacts`  | Class Lib | Auto-collect logs/screenshots on fail. |
| `Dotisan.Slack`      | Tool      | Push reports to Slack/Teams. |
| `Dotisan.History`    | Tool      | Track test flakiness across builds. |

---

### 7. Templates
| Package                 | Type      | Purpose |
|-------------------------|-----------|---------|
| `Dotisan.Templates`     | Template  | Bundle of `dotnet new` templates: unit, contract, integration. |

**Usage:**
```sh
dotnet new install Dotisan.Templates
dotnet new dotisan-contract -n MyContractTests
```

---

### 8. Meta
| Package            | Type      | Purpose |
|--------------------|-----------|---------|
| `Dotisan.All`      | Meta      | Convenience package that pulls in core Dotisan libs (Assert, Timer, Diff, Coverage). |

---

## 🛠 Project Types Explained

- **Class Lib NuGet** → reusable logic (assertions, helpers, wrappers).  
- **Analyzer/Source Generator** → compile-time diagnostics & code-gen.  
- **Middleware** → ASP.NET Core pipeline components.  
- **Tool (`dotnet tool`)** → CLI utilities (reporters, dashboards, snapshots).  
- **Template** → scaffolding via `dotnet new`.  
- **Meta** → empty NuGet that references multiple Dotisan packages.  

---

## 🚀 Getting Started
Example: install and use `Dotisan.Assert`
```sh
dotnet add package Dotisan.Assert
```

```csharp
using Dotisan.Assert;

"Rudi".ShouldBe("Rudi", because: "names must match");
```

---

## 📦 Vision Roadmap
1. **Phase 1 (MVP)** – Build small, sharp utilities:  
   - `Dotisan.Assert`, `Dotisan.Timer`, `Dotisan.Diff`, `Dotisan.Coverage`  
2. **Phase 2** – Add ecosystem support:  
   - `Dotisan.Unit`, `Dotisan.Reporter`, `Dotisan.CoverageGuard`, `Dotisan.Mock`  
3. **Phase 3** – Round out integrations & tooling:  
   - `Dotisan.HttpMock`, `Dotisan.Trend`, `Dotisan.Slack`, `Dotisan.Templates`  

---

## 📜 License
MIT – free to use, extend, and share.  

---

## 🤝 Contributing
Contributions welcome! Start small:
- Suggest new Dotisan packages.
- Improve docs or add samples.
- Submit bugfixes or new assertion extensions.

---

## 🌟 Why Dotisan?
- Cohesive ecosystem.  
- Built “for .NET devs, by .NET devs.”  
- Fills the **missing middle** between heavy frameworks and DIY utilities.  
- Inspired by the legendary **Sebastian Bergmann PHP stack**.  

**Dotisan = Crafted Tools for .NET Developers.**
