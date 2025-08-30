# ---------- Build Stage ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and projects
COPY *.sln ./
COPY ./src/AppHost/AppHost.csproj ./src/AppHost/
COPY ./src/Modules ./src/Modules
COPY ./src/Shared ./src/Shared

# Restore dependencies for AppHost
WORKDIR /src/AppHost
RUN dotnet restore AppHost.csproj

# Build and publish
RUN dotnet publish -c Release -o /app --no-restore

# ---------- Runtime Stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy published app
COPY --from=build /app ./

# Run EF migrations before starting the app
ENTRYPOINT ["sh", "-c", "dotnet ef database update --no-build --project /src/AppHost/AppHost.csproj && dotnet AppHost.dll"]
