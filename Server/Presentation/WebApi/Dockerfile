#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Server/Presentation/WebApi/WebApi.csproj", "Server/Presentation/WebApi/"]
COPY ["Server/Infrastructure/WebApi.EF/WebApi.EF.csproj", "Server/Infrastructure/WebApi.EF/"]
COPY ["Models/Models/Models.csproj", "Models/Models/"]
RUN dotnet restore "Server/Presentation/WebApi/WebApi.csproj"
COPY . .
WORKDIR "/src/Server/Presentation/WebApi"
RUN dotnet build "WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApi.dll"]