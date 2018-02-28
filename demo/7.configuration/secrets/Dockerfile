FROM microsoft/dotnet-nightly:2.1-sdk-alpine AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY nuget.config ./
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out -r alpine.3.6-x64

# build runtime image
FROM microsoft/dotnet-nightly:2.1-runtime-deps-alpine
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT ["/app/configuration"]