# ---------- Build Stage ----------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy solution file
COPY CoinPlay.sln ./

# Copy all source files
COPY src ./

# Move to AppHost project
WORKDIR /src/AppHost

# Restore dependencies
RUN dotnet restore AppHost.csproj

# Build and publish
RUN dotnet publish -c Release -o /app --no-restore

# Run EF migrations in build stage
RUN dotnet ef database update --no-build --project AppHost.csproj

# ---------- Runtime Stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Copy published app
COPY --from=build /app ./

# Start app
ENTRYPOINT ["dotnet", "AppHost.dll"]
