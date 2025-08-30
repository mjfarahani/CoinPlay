# ---------- Build Stage ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything
COPY ../../ ./

# Restore dependencies
WORKDIR /src/AppHost
RUN dotnet restore

# Build
RUN dotnet publish -c Release -o /app --no-restore

# ---------- Runtime Stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy published app
COPY --from=build /app ./

# Run EF migrations before starting
ENTRYPOINT ["sh", "-c", "dotnet ef database update --no-build --project /src/AppHost/AppHost.csproj && dotnet AppHost.dll"]
