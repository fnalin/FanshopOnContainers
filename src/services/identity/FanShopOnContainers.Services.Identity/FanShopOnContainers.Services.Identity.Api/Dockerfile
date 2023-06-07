FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FanShopOnContainers.Services.Identity.Api/FanShopOnContainers.Services.Identity.Api.csproj", "FanShopOnContainers.Services.Identity.Api/"]
RUN dotnet restore "FanShopOnContainers.Services.Identity.Api/FanShopOnContainers.Services.Identity.Api.csproj"
COPY . .
WORKDIR "/src/FanShopOnContainers.Services.Identity.Api"
RUN dotnet build "FanShopOnContainers.Services.Identity.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FanShopOnContainers.Services.Identity.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FanShopOnContainers.Services.Identity.Api.dll"]
