FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/task.Web.Host/task.Web.Host.csproj", "src/task.Web.Host/"]
COPY ["src/task.Web.Core/task.Web.Core.csproj", "src/task.Web.Core/"]
COPY ["src/task.Application/task.Application.csproj", "src/task.Application/"]
COPY ["src/task.Core/task.Core.csproj", "src/task.Core/"]
COPY ["src/task.EntityFrameworkCore/task.EntityFrameworkCore.csproj", "src/task.EntityFrameworkCore/"]
WORKDIR "/src/src/task.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/task.Web.Host", "src/task.Web.Host"]
COPY ["src/task.Web.Core", "src/task.Web.Core"]
COPY ["src/task.Application", "src/task.Application"]
COPY ["src/task.Core", "src/task.Core"]
COPY ["src/task.EntityFrameworkCore", "src/task.EntityFrameworkCore"]
WORKDIR "/src/src/task.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "task.Web.Host.dll"]
