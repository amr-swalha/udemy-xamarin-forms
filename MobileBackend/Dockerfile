FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MobileBackend/MobileBackend.csproj", "MobileBackend/"]
RUN dotnet restore "MobileBackend/MobileBackend.csproj"
COPY . .
WORKDIR "/src/MobileBackend"
RUN dotnet build "MobileBackend.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MobileBackend.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MobileBackend.dll"]