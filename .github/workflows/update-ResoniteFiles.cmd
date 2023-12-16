:: Note: This command needs the %ResonitePath% to be set! (quick & dirty code: does not check that)
rmdir /S /Q Resonite
mkdir Resonite\Resonite_Data\Managed\
powershell -Command Copy -Destination 'Resonite' -Path '%ResonitePath%\*.dll' -Exclude 'MonkeyLoader.dll','Mono*','NuGet*','winhttp.dll','Zio.dll','0Harmony.dll'
powershell -Command Copy -Destination 'Resonite\Resonite_Data\Managed\' -Path '%ResonitePath%\Resonite_Data\Managed\*.dll'
:: powershell -Command Compress-Archive -Force -DestinationPath Resonite.zip -Path Resonite