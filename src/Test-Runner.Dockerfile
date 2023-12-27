# build context /src
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY Code-Kata-CLP.sln .
COPY CLP-Service/CLP-Service.csproj ./CLP-Service/
COPY CLP-Service.integrationtests/CLP-Service.integrationtests.csproj ./CLP-Service.integrationtests/
COPY CLP-Service.unittests/CLP-Service.unittests.csproj ./CLP-Service.unittests/
RUN dotnet restore Code-Kata-CLP.sln

COPY . .
RUN dotnet build -c Release --no-restore Code-Kata-CLP.sln

CMD dotnet test -c Release --no-restore /app/Code-Kata-CLP.sln