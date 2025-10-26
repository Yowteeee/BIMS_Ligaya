@echo off
echo Cleaning up running processes...

REM Kill any running instances of the application
taskkill /F /IM ligaya_bims.exe 2>nul

REM Wait a moment for processes to terminate
timeout /t 2 /nobreak >nul

REM Clean the output directory
if exist "bin\Debug\ligaya_bims.exe" del "bin\Debug\ligaya_bims.exe"
if exist "obj\Debug\ligaya_bims.exe" del "obj\Debug\ligaya_bims.exe"

echo Building project...
msbuild ligaya_bims.vbproj /p:Configuration=Debug /p:Platform="Any CPU"

echo Build completed!
pause

