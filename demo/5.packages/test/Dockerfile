FROM microsoft/dotnet:2.0-sdk AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY test.sln ./test.sln
COPY program/program.csproj ./program/program.csproj
COPY program.tests/program.tests.csproj ./program.tests/program.tests.csproj
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet test program.tests -c Release
RUN dotnet publish program -c Release -o /app/out

# build runtime image
FROM microsoft/dotnet:2.0-runtime
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT ["dotnet", "program.dll"]