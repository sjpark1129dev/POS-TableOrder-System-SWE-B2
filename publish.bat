@echo off
chcp 65001 > nul
setlocal

REM ====== 기본 설정 ======
set DOTNET_RUNTIME=win-x64
set CONFIG=Release
set FRAMEWORK=net8.0-windows

REM ====== 폴더 구조 ======
set OUTPUT_DIR=publish
set POS_OUTPUT=%OUTPUT_DIR%\POS
set TO_OUTPUT=%OUTPUT_DIR%\TableOrder

REM ====== 1. POS 빌드 ======
echo [1/2] POS publish 중...
dotnet publish ./POS/POS.csproj -c %CONFIG% -r %DOTNET_RUNTIME% --self-contained true ^
 -p:PublishSingleFile=true ^
 -p:IncludeNativeLibrariesForSelfExtract=true ^
 -p:EnableCompressionInSingleFile=true ^
 -o %POS_OUTPUT%

echo → POS.pdb 삭제 중...
del /f /q "%POS_OUTPUT%\*.pdb" > nul

echo → POS.zip 압축 중...
powershell Compress-Archive -Path "%POS_OUTPUT%\*" -DestinationPath "%OUTPUT_DIR%\POS.zip" -Force

REM ====== 2. TableOrder 빌드 ======
echo [2/2] TableOrder publish 중...
dotnet publish ./TableOrder/TableOrder.csproj -c %CONFIG% -r %DOTNET_RUNTIME% --self-contained true ^
 -p:PublishSingleFile=true ^
 -p:IncludeNativeLibrariesForSelfExtract=true ^
 -p:EnableCompressionInSingleFile=true ^
 -o %TO_OUTPUT%

echo → TableOrder.pdb 삭제 중...
del /f /q "%TO_OUTPUT%\*.pdb" > nul

echo → TableOrder.zip 압축 중...
powershell Compress-Archive -Path "%TO_OUTPUT%\*" -DestinationPath "%OUTPUT_DIR%\TableOrder.zip" -Force

echo ✅ 모두 완료되었습니다! ZIP 파일이 다음 경로에 생성됨:
echo  - %OUTPUT_DIR%\POS.zip
echo  - %OUTPUT_DIR%\TableOrder.zip
pause
