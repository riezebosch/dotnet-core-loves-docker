## runtime identifier

<pre class="stretch"><code class="Dockerfile" data-trim data-noescape>
FROM microsoft/dotnet:2.0-sdk AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore <mark>-r linux-x64</mark>

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out <mark>-r linux-x64</mark>

# build runtime image
FROM microsoft/dotnet:2.0-runtime-deps
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT ["/app/self-contained"]
</code></pre>

<small>[.NET Core RID Catalog](https://docs.microsoft.com/nl-nl/dotnet/core/rid-catalog)</small>