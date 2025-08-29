# CoinPlay — Educational iGaming-style Template

This repository is a learning project inspired by iGaming architecture.
It uses virtual coins only — no real-money gambling.

⚠️ Disclaimer: Educational purposes only. Do not use for real-money betting without licenses and legal advice.

## Run locally
```bash
docker compose up --build
dotnet ef database update --project src/AppHost
dotnet run --project src/AppHost
```
