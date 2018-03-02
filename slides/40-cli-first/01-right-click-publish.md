Right Click Publish in a Container
<pre class="stretch"><code class="Dockerfile" data-trim data-noescape>
FROM build:latest AS build-env
ARG RUNTIME=net471
WORKDIR /app

COPY ./MvcMusicStore/packages.config ./packages.config
RUN nuget restore packages.config packages
COPY . ./
RUN nuget restore
<mark>RUN C:\BuildTool\MSBuild\15.0\bin\msbuild.exe \
    MvcMusicStore\MvcMusicStore.csproj \
    /p:Configuration=Release \
    /p:DeployOnBuild=true \
    /p:PublishProfile=FolderProfile</mark>

FROM microsoft/aspnet:4.7.1-windowsservercore-1709
ARG source
WORKDIR /inetpub/wwwroot
COPY --from=build-env /app/MvcMusicStore/bin/Release/PublishOutput ./
</code></pre>