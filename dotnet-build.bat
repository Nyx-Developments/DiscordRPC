@echo off
@title Discord RPC Emulator NET Core build script
echo Begin Debug Build...
title Building [DEBUG]
timeout 1 > NUL
echo Building for Windows...
title Building [DEBUG] Windows
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Debug
echo Building for macOS...
title Building [DEBUG] MacOS
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Debug --runtime osx-x64
mkdir AquaDRPCE/bin/Debug/netcoreapp3.1/osx-x64/runtimes
robocopy AquaDRPCE/bin/Debug/netcoreapp3.1/runtimes AquaDRPCE/bin/Debug/netcoreapp3.1/osx-x64/runtimes /E
echo Building for Linux...
title Building [DEBUG] Linux
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Debug --runtime linux-x64
mkdir AquaDRPCE/bin/Debug/netcoreapp3.1/linux-x64/runtimes
robocopy AquaDRPCE/bin/Debug/netcoreapp3.1/runtimes AquaDRPCE/bin/Debug/netcoreapp3.1/linux-x64/runtimes /E
echo Begin Release Build...
title Building [RELEASE]
timeout 1 > NUL
echo Building for Windows...
title Building [RELEASE] Windows
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Release
echo Building for macOS...
title Building [RELEASE] MacOS
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Release --runtime osx-x64
mkdir AquaDRPCE/bin/Release/netcoreapp3.1/osx-x64/runtimes
robocopy AquaDRPCE/bin/Release/netcoreapp3.1/runtimes AquaDRPCE/bin/Release/netcoreapp3.1/osx-x64/runtimes /E
echo Building for Linux...
title Building [RELEASE] Linux
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Release --runtime linux-x64
mkdir AquaDRPCE/bin/Release/netcoreapp3.1/linux-x64/runtimes
robocopy AquaDRPCE/bin/Release/netcoreapp3.1/runtimes AquaDRPCE/bin/Release/netcoreapp3.1/linux-x64/runtimes /E
echo Done, exiting in 5 seconds
timeout 5 < NUL