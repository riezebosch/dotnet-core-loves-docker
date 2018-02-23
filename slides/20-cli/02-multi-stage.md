<pre><code class="Dockerfile" data-trim data-noescape>
FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
<mark>RUN dotnet restore</mark>

# copy everything else and build
COPY . ./
<mark>RUN dotnet publish -c Release -o out</mark>

# build runtime image
FROM microsoft/dotnet:runtime
WORKDIR /app
<mark>COPY --from=build-env /app/out ./</mark>
ENTRYPOINT ["dotnet", "dotnetapp.dll"]
</code></pre>

<!-- .element class="stretch" -->