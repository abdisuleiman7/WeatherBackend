FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["Weather.Api.REST/Weather.Api.REST.csproj", "Weather.Api.REST/"]
RUN dotnet restore "Weather.Api.REST/Weather.Api.REST.csproj"
COPY . .
WORKDIR "/src/Weather.Api.REST"
RUN dotnet build "Weather.Api.REST.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Weather.Api.REST.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Weather.Api.REST.dll"]
