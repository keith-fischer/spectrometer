@echo off
REM Remove files generated by compiler in this directory
REM and all subdirectories.

echo Removing *.pdb files...
del *.pdb /f /q /s
echo.

echo Removing vshost.exe* files...
del *.vshost.exe* /f /q /s
echo.

rd Sources\obj /S /Q

echo Done.
