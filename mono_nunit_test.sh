#!/usr/bin/env bash
#
# Generated by: https://github.com/swagger-api/swagger-codegen.git
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

wget -nc https://nuget.org/nuget.exe
mozroots --import --sync

echo "[INFO] remove bin/Debug/SwaggerClientTest.dll"
rm src/IO.Swagger.Test/bin/Debug/com.precisely.apis.Test.dll 2> /dev/null

echo "[INFO] install NUnit runners via NuGet"
wget -nc https://nuget.org/nuget.exe
mozroots --import --sync
mono nuget.exe install src/com.precisely.apis.Test/packages.config -o packages

echo "[INFO] Install NUnit runners via NuGet"
mono nuget.exe install NUnit.Runners -Version 3.2.1 -OutputDirectory packages 

echo "[INFO] Build the solution and run the unit test"
xbuild com.precisely.apis.sln && \
    mono ./packages/NUnit.ConsoleRunner.3.2.1/tools/nunit3-console.exe src/com.precisely.apis.Test/bin/Debug/com.precisely.apis.Test.dll
