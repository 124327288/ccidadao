set /p SVN_REVISION= < "%~dp0..\svn_revision"

set OUTPUT_FILE=%~dp0Properties\AssemblyInfo.cs

echo // File generated by prebuild step 			> "%OUTPUT_FILE%"
echo using System.Reflection; 					>> "%OUTPUT_FILE%"
echo using System.Runtime.CompilerServices;			>> "%OUTPUT_FILE%"
echo using System.Runtime.InteropServices;			>> "%OUTPUT_FILE%"
echo [assembly: AssemblyTitle("pteidlib_dotnet")]		>> "%OUTPUT_FILE%"
echo [assembly: AssemblyDescription("")]			>> "%OUTPUT_FILE%"
echo [assembly: AssemblyConfiguration("")]			>> "%OUTPUT_FILE%"
echo [assembly: AssemblyCompany("Portuguese Government")]		>> "%OUTPUT_FILE%"
echo [assembly: AssemblyProduct("pteidlib_dotnet")]	>> "%OUTPUT_FILE%"
echo [assembly: AssemblyCopyright("Copyright (C) 2017")]	>> "%OUTPUT_FILE%"
echo [assembly: AssemblyTrademark("")]				>> "%OUTPUT_FILE%"
echo [assembly: AssemblyCulture("")]				>> "%OUTPUT_FILE%"
echo [assembly: ComVisible(false)]				>> "%OUTPUT_FILE%"
echo [assembly: Guid("a69697fa-c784-4923-8476-2ee828accae8")]	>> "%OUTPUT_FILE%"
echo [assembly: AssemblyVersion("3.0.0.%SVN_REVISION%")]	>> "%OUTPUT_FILE%"
echo [assembly: AssemblyFileVersion("2.4.0.%SVN_REVISION%")]	>> "%OUTPUT_FILE%"

exit 0