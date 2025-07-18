FROM mcr.microsoft.com/dotnet/aspnet:8.0.6 AS base

WORKDIR /app

EXPOSE 80



FROM mcr.microsoft.com/dotnet/sdk:8.0.300 AS build

WORKDIR /src

COPY . .

RUN dotnet restore "TheoryAndPixel.csproj"

RUN dotnet publish "TheoryAndPixel.csproj" -c Release -o /app/publish 



FROM base AS final

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "TheoryAndPixel.dll"]
