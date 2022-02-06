#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Restaurant.APP/Restaurant.APP.csproj", "Restaurant.APP/"]
RUN dotnet restore "Restaurant.APP/Restaurant.APP.csproj"
COPY . .
WORKDIR "/src/Restaurant.APP"
RUN dotnet build "Restaurant.APP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Restaurant.APP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Restaurant.APP.dll"]