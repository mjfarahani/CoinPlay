# ---------- Build Stage ----------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy solution file
COPY CoinPlay.sln ./

# Copy all source files directly
COPY src ./  

# Move to AppHost project
WORKDIR /src/AppHost

# Restore dependencies
RUN dotnet restore AppHost.csproj

# Build and publish
RUN dotnet publish -c Release -o /app --no-restore

# ---------- Runtime Stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Copy published app
COPY --from=build /app ./

# Start the application
ENTRYPOINT ["dotnet", "AppHost.dll"]
