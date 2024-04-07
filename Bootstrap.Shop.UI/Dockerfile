FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Bootstrap.Shop.Ui/Bootstrap.Shop.Ui.csproj", "Bootstrap.Shop.Ui/"]
RUN dotnet restore "Bootstrap.Shop.Ui/Bootstrap.Shop.Ui.csproj"
COPY . .
WORKDIR "/src/Bootstrap.Shop.Ui"
RUN dotnet build "Bootstrap.Shop.Ui.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Bootstrap.Shop.Ui.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bootstrap.Shop.Ui.dll"]
