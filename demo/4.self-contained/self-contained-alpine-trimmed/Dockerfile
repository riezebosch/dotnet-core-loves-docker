FROM microsoft/dotnet-nightly:2.1-sdk AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY nuget.config ./
COPY *.csproj ./
RUN dotnet restore -r alpine.3.6-x64

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out -r alpine.3.6-x64 /p:ShowLinkerSizeComparison=true /p:TrimUnusedDependencies=true

# build runtime image
FROM microsoft/dotnet-nightly:2.1-runtime-deps-alpine
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT ["/app/self-contained"]