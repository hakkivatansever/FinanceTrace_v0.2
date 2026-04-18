💰 FinanceTrace

> Simple personal finance tracker built with C# and .NET 8.  
> A learning project to practice core C# concepts: OOP, LINQ, and file I/O.

![App Screenshot](screenshot.png)

---

## ✨ Features

- 📥 Add income and expenses through an interactive menu
- 📊 View real-time summary with balance calculation
- ✅ Input validation using `TryParse` — no crashes on invalid input
- 🌍 UTF-8 console output for proper currency symbols (₺, €, $)
- 🎨 Clean, menu-driven CLI interface

## 🛠️ Tech Stack

- **Language:** C# 12
- **Framework:** .NET 8 (LTS)
- **IDE:** Visual Studio 2022 Community
- **Version Control:** Git & GitHub

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Any terminal (Windows, macOS, Linux supported)

### Installation

Clone the repository:
```bash
git clone https://github.com/⭐KULLANICI-ADIN/FinanceTrace.git
cd FinanceTrace
```

Run the application:
```bash
dotnet run
```

## 📁 Project Structure

FinanceTrace/
├── Program.cs              # Entry point & main menu loop
├── FinanceTrace.csproj     # Project configuration
├── screenshot.png          # Demo screenshot
└── README.md               # You are here

## 🗺️ Roadmap

- [x] Menu-driven input system
- [x] Input validation with `TryParse`
- [ ] Persistent storage (JSON file)
- [ ] Categories for expenses (food, rent, transport...)
- [ ] Monthly reports using LINQ
- [ ] Export to CSV
- [ ] Migrate to ASP.NET Core Web API

## 📚 What I Learned

Throughout this project I practiced:

- **C# fundamentals:** types, null safety (`string?`), `var`, `const`
- **Control flow:** `while` loops, `switch` statements, `switch` expressions
- **Methods:** parameters, return types, `out` keyword
- **Error-safe input:** `TryParse` pattern instead of `Parse`
- **Encoding:** why `Console.OutputEncoding = Encoding.UTF8` matters
- **Git workflow:** conventional commits, `.gitignore`, remote repositories

## 👤 Author

**⭐Hakkı VATANSEVER**
- GitHub: https://github.com/hakkivatansever
- LinkedIn: https://www.linkedin.com/in/hakkivatansever/

---

⭐ If you found this useful, consider starring the repo!