# Lethal Company mod example

### Compilation from source

### Requirements
1. Any .NET implementation that supports ``netstandard2.1`` and C# 10+.
2. An installed **Lethal Company** on your PC.

#### Compilation steps:
1. Set the game directory variable (e.g. ``D:\SteamLibrary\steamapps\common\Lethal Company``):

**For Windows cmd.exe**
```batch
set LETHAL_COMPANY_DIR="game directory here".
```

**For PowerShell**
```powershell
$env:LETHAL_COMPANY_DIR="game directory here"
```

**For bash**
```bash
LETHAL_COMPANY_DIR="game directory here"
```

2. Run ``dotnet build -P:Configuration=Release`` to compile the mod from source with *Release* configuration.
