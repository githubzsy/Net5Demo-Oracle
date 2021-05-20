# 使用说明

## DBFirst
1.设置启动项为webapi
2.设置Consts中使用的连接字符串
3.打开nuget 管理器命令，选择项目为webapi.ef，执行 update-database更新数据库

## 环境变量
```
set ASPNETCORE_ENVIRONMENT=development
set ASPNETCORE_URLS=http://localhost:5000
```