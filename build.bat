:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::
:: Licensed under the Apache License, Version 2.0 (the "License");
:: you may not use this file except in compliance with the License.
:: You may obtain a copy of the License at
::
::      http://www.apache.org/licenses/LICENSE-2.0
::
:: Unless required by applicable law or agreed to in writing, software
:: distributed under the License is distributed on an "AS IS" BASIS,
:: WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
:: See the License for the specific language governing permissions and
:: limitations under the License.

@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319


if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\com.precisely.apis\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.12.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.106.6.10\lib\net452\RestSharp.dll bin\RestSharp.dll
copy packages\ILMerge.3.0.41\tools\net452\ILMerge.exe bin\ILMerge.exe
%CSCPATH%\csc -nowarn:0109,1591,1573 /reference:bin\Newtonsoft.Json.dll;bin\RestSharp.dll /target:library /out:bin\PreciselyAPIsCSharpSDK-11.0.1.dll /recurse:src\com.precisely.apis\*.cs /doc:bin\com.precisely.apis.xml
cd bin
mkdir comb
ilmerge /out:comb/PreciselyAPIsCSharpSDK-11.0.1.dll Newtonsoft.Json.dll RestSharp.dll PreciselyAPIsCSharpSDK-11.0.1.dll
exit 0




