# CoinPlay

This repository is a learning project inspired by iGaming architecture.
It uses virtual coins only — no real-money gambling.

⚠️ Disclaimer: Educational purposes only. Do not use for real-money betting without licenses and legal advice.

CoinPlay is a modular betting & gamification platform built with .NET 9.

## Project Purpose
This project is created for learning, experimenting with microservices/modular monolith architecture, and building a public MVP for gamified betting.

## Project Structure

- /src
  - AppHost → main API project
  - Modules → Identity, Wallet, Catalog, Prediction, Settlement, Gamification
  - Shared → common utilities and models
- /tests → unit and integration tests
- /infra → database migrations, Docker Compose

## Setup

1. Ensure Docker is installed.
2. Run `docker-compose up` to start PostgreSQL and Redis.
3. Run `dotnet build` in the solution root.
4. Run `dotnet run --project src/AppHost/AppHost.csproj` to start the API.
