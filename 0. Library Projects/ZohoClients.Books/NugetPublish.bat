for %%I in (.) do set CurrDirName=%%~nxI

del *.nupkg

"C:\Users\Jamie\Documents\Software Development\nuget.exe" pack %CurrDirName%.nuspec

"C:\Users\Jamie\Documents\Software Development\nuget.exe" add %CurrDirName%.1.0.0.nupkg -Source "C:\Users\Jamie\Documents\Software Development\NuGet Packages"
