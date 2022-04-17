#!/bin/bash
stty -echo
mytitle="Discord RPC Emulator NET Core build script"
echo -e '\033]2;'$mytitle'\007'
echo Begin Debug Build...
mytitle="Building [DEBUG]"
echo -e '\033]2;'$mytitle'\007'
sleep 1
echo Building for Windows...
mytitle="Building [DEBUG] Windows"
echo -e '\033]2;'$mytitle'\007'
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Debug
echo Building for macOS...
mytitle="Building [DEBUG] MacOS"
echo -e '\033]2;'$mytitle'\007'
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Debug --runtime osx-x64
cp -R AquaDRPCE/bin/Debug/runtimes AquaDRPCE/bin/Debug/osx-x64/runtimes/
echo Building for Linux...
mytitle="Building [DEBUG] Linux"
echo -e '\033]2;'$mytitle'\007'
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Debug --runtime linux-x64
cp -R AquaDRPCE/bin/Debug/runtimes AquaDRPCE/bin/Debug/linux-x64/runtimes/
echo Begin Release Build...
mytitle="Building [RELEASE]"
echo -e '\033]2;'$mytitle'\007'
sleep 1
echo Building for Windows...
mytitle="Building [RELEASE] Windows"
echo -e '\033]2;'$mytitle'\007'
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Release
echo Building for macOS...
mytitle="Building [RELEASE] MacOS"
echo -e '\033]2;'$mytitle'\007'
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Release --runtime osx-x64
cp -R AquaDRPCE/bin/Release/runtimes AquaDRPCE/bin/Release/osx-x64/runtimes/
echo Building for Linux...
mytitle="Building [RELEASE] Linux"
echo -e '\033]2;'$mytitle'\007'
dotnet build AquaDRPCE/AquaDRPCE.csproj -c Release --runtime linux-x64
cp -R AquaDRPCE/bin/Release/runtimes AquaDRPCE/bin/Release/linux-x64/runtimes/
echo Done, exiting in 5 seconds
sleep 5