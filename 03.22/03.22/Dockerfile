#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["03.22/03.22.csproj", "03.22/"]
RUN dotnet restore "03.22/03.22.csproj"
COPY . .
WORKDIR "/src/03.22"
RUN dotnet build "03.22.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "03.22.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "03.22.dll"]