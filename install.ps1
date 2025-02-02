$TargetVersion = "v1.1.0"


function Install-DotNET {
    try {
        Invoke-WebRequest "https://download.visualstudio.microsoft.com/download/pr/f6b6c5dc-e02d-4738-9559-296e938dabcb/b66d365729359df8e8ea131197715076/windowsdesktop-runtime-6.0.36-win-x64.exe" -OutFile "$env:TEMP\windowsdesktop-runtime.exe"
    }
    catch {
        Write-Host "Fail to download .NET Runtime"
        Write-Host $_
        Exit 1
    }

    Start-Process "$env:TEMP\windowsdesktop-runtime.exe" -ArgumentList "/install", "/quiet", "/norestart" -Wait

    Remove-Item "$env:TEMP\windowsdesktop-runtime.exe"
}

function Install-MultiRoblox {
    $StartupFolder = "$env:APPDATA\Microsoft\Windows\Start Menu\Programs\Startup"

    try {
        Invoke-WebRequest "https://github.com/Dlunhappy226/MultiRoblox/releases/download/$TargetVersion/MultiRoblox.exe" -OutFile "$env:TEMP\MultiRoblox.exe"
    }
    catch {
        Write-Host "Fail to download MultiRoblox"
        Write-Host $_
        Exit 1
    }

    if (Test-Path "$StartupFolder\MultiRoblox.exe") {Remove-Item "$StartupFolder\MultiRoblox.exe"}

    Move-Item "$env:TEMP\MultiRoblox.exe" "$StartupFolder\MultiRoblox.exe"

    Start-Process "$StartupFolder\MultiRoblox.exe"

    Write-Host "Successfully installed MultiRoblox"
}

function Update-MultiRoblox {
    try {
        Invoke-WebRequest "https://github.com/Dlunhappy226/MultiRoblox/releases/download/$TargetVersion/MultiRoblox.exe" -OutFile "$env:TEMP\MultiRoblox.exe"
    }
    catch {
        Write-Host "Fail to download MultiRoblox"
        Write-Host $_
        Exit 1
    }

    Remove-Item "MultiRoblox.exe"
    Move-Item "$env:TEMP\MultiRoblox.exe" "MultiRoblox.exe"

    Start-Process "MultiRoblox.exe"

    Write-Host "Successfully updating MultiRoblox"
}

if (Test-Path "MultiRoblox.exe") {
    Write-Host "Updating MultiRoblox..."
    Update-MultiRoblox
}
else {
    Write-Host "Installing .NET Runtime..."
    Install-DotNet

    Write-Host "Installing MultiRoblox..."
    Install-MultiRoblox
}