#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
# 基础镜像
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
# 拷贝所有的文件到/app
COPY . /app
# 设置工作目录为app
WORKDIR /app
# 设置容器内部暴露端口号为80
EXPOSE 80
# 设置环境变量
ENV ASPNETCORE_ENVIRONMENT=development
# 设置起始命令 dotnet WebApi.dll
ENTRYPOINT ["dotnet", "WebApi.dll"]