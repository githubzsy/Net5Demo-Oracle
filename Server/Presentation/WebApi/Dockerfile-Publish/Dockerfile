#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
COPY . /app
WORKDIR /app
EXPOSE 80
ENV ASPNETCORE_ENVIRONMENT=development
ENTRYPOINT ["dotnet", "WebApi.dll"]