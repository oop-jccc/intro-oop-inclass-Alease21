# Intro to Object-Oriented Programming with C#

[![.NET CI/CD Pipeline](https://github.com/oop-jccc/intro-oop/actions/workflows/ci.yml/badge.svg)](https://github.com/oop-jccc/intro-oop/actions/workflows/ci.yml)

This repository is designed as a comprehensive learning environment for understanding and practicing object-oriented programming (OOP) concepts in C#. It provides multiple branches with different examples, exercises, and solutions to help students progress through various OOP topics.

## 🚀 Quick Start

### Option 1: GitHub Codespaces (Recommended)
The fastest way to get started is using GitHub Codespaces, which provides a fully configured development environment in the cloud.

1. Click the **Code** button on this repository
2. Select **Codespaces** tab
3. Click **Create codespace on [branch-name]**
4. Wait for the environment to initialize (this may take a few minutes)
5. Once ready, you can immediately start coding with full IntelliSense and debugging support

### Option 2: Local Development with VS Code
1. **Prerequisites:**
   - [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
   - [Visual Studio Code](https://code.visualstudio.com/)
   - [C# Dev Kit extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)

2. **Clone and Setup:**
   ```bash
   git clone https://github.com/oop-jccc/intro-oop.git
   cd intro-oop
   code .
   ```

3. **Restore Dependencies:**
   ```bash
   dotnet restore intro-oop/intro-oop.csproj
   ```

## 🔧 Build and Debug

### Using VS Code Tasks
This repository includes pre-configured VS Code tasks for common operations:

- **Build:** `Ctrl+Shift+P` → "Tasks: Run Task" → "build"
- **Run:** `Ctrl+Shift+P` → "Tasks: Run Task" → "run"
- **Clean:** `Ctrl+Shift+P` → "Tasks: Run Task" → "clean"
- **Watch:** `Ctrl+Shift+P` → "Tasks: Run Task" → "watch" (auto-rebuilds on file changes)

### Using Command Line
```bash
# Navigate to the project directory
cd intro-oop

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run

# Clean build artifacts
dotnet clean

# Watch for changes and auto-rebuild
dotnet watch run
```

### Debugging in VS Code
1. Open the project in VS Code
2. Set breakpoints by clicking in the left margin of the code editor
3. Press `F5` or go to **Run and Debug** panel
4. Select ".NET Core Launch (console)" configuration
5. The debugger will start and stop at your breakpoints

## 📚 Repository Structure

### Branches Overview
This repository contains multiple branches, each focusing on different OOP concepts:

- **1.x branches:** Basic geometry classes and OOP fundamentals
- **2.x branches:** Testing and validation concepts
- **3.x branches:** Inheritance vs composition patterns
- **4.x branches:** Dependency injection and design patterns
- **5.x branches:** Advanced polymorphism and decorators
- **7.x-9.x branches:** SOLID principles (LSP, ISP, DIP)
- **10.x branches:** Advanced decorator patterns

### Project Structure
```
intro-oop/
├── intro-oop.csproj          # Project configuration
├── intro-oop.sln             # Solution file
├── Program.cs                # Application entry point
├── Circle.cs                 # Circle class implementation
├── Location*.cs              # Various location class implementations
└── Readme.md                 # Project-specific documentation
```

## 🛠️ Development Environment Features

### VS Code Configuration
- **IntelliSense:** Full C# code completion and suggestions
- **Debugging:** Integrated debugging with breakpoints and variable inspection
- **Tasks:** Pre-configured build, run, and test tasks
- **Extensions:** Automatically installed C# development extensions

### DevContainer/Codespaces Features
- **High-Performance Environment:** 8 CPU cores, 16GB RAM
- **Pre-installed Extensions:**
  - C# Dev Kit with full language support
  - GitHub Copilot for AI-assisted coding
  - Visual Assist for enhanced productivity
  - Better C# syntax highlighting
  - IL Spy for .NET decompilation
  - NuGet Gallery integration
  - Coverage gutters for test coverage
  - REST Client for API testing

### Continuous Integration
- **Automated Builds:** Every push and pull request triggers automated builds
- **Multi-job Pipeline:** Build, test, code quality, and security scanning
- **Artifact Storage:** Build outputs are stored for 30 days
- **Cross-branch Support:** CI runs on all branches to ensure consistency

## 📖 Learning Path

### For Beginners
1. Start with branch `1.1-geometry` for basic class concepts
2. Progress through `1.x` branches to understand OOP fundamentals
3. Move to `2.x` branches to learn about testing
4. Explore `3.x` branches for inheritance and composition

### For Intermediate Students
1. Focus on `4.x` branches for dependency injection patterns
2. Study `5.x` branches for advanced polymorphism
3. Work through `7.x-9.x` branches for SOLID principles

### For Advanced Students
1. Examine `10.x` branches for complex design patterns
2. Contribute improvements to the CI/CD pipeline
3. Add comprehensive test suites to existing branches

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/your-feature-name`
3. Make your changes and commit: `git commit -m "Add your feature"`
4. Push to your fork: `git push origin feature/your-feature-name`
5. Create a Pull Request

## 📝 Code Style

This project follows standard C# coding conventions:
- PascalCase for public members and types
- camelCase for private fields and local variables
- Meaningful names for classes, methods, and variables
- XML documentation comments for public APIs
- Warnings treated as errors in both Debug and Release configurations

## 🔍 Troubleshooting

### Common Issues

**Build Errors:**
- Ensure .NET 8.0 SDK is installed
- Run `dotnet restore` to restore NuGet packages
- Check that you're in the correct directory (`intro-oop/`)

**VS Code Issues:**
- Install the C# Dev Kit extension
- Reload VS Code window: `Ctrl+Shift+P` → "Developer: Reload Window"
- Check that .NET is properly installed: `dotnet --version`

**Codespaces Issues:**
- Wait for the environment to fully initialize
- If extensions aren't working, try rebuilding the container
- Check the terminal for any error messages during setup

## 📞 Support

If you encounter issues or have questions:
1. Check the troubleshooting section above
2. Review existing GitHub Issues
3. Create a new issue with detailed information about your problem
4. Include your operating system, .NET version, and VS Code version

---

Happy coding! 🎉
