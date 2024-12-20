FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS my-app

WORKDIR /app

COPY . .

RUN dotnet publish -c Release -o /app/out

#FROM mcr.microsoft.com/dotnet/aspnet:7.0

FROM nginx:alpine

WORKDIR /usr/share/nginx/html

COPY --from=my-app /app/out .

#ENTRYPOINT ["dotnet", "YourAppName.dll"]
