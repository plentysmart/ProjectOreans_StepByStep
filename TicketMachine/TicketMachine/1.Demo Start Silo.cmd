@setlocal
@echo off
@if NOT "%ECHO%"=="" @echo %ECHO%
cd TicketMaster.WebUI\bin
"%OrleansSDK%\Binaries\OrleansServer\OrleansHost.exe" DevSilo ..\OrleansConfiguration.xml
