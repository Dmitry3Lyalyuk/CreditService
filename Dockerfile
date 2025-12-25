 #Build stage 
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS build 
WORKDIR /app
COPY ..
RUN dotnet restore 
RUN dotnet publish -c Release -o out

#Runtime stage 
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine
WORKDIR /app
COPY --from=build /app/out .
EXPOSE 8080
USER $APP_UID

ENTRYPOINT ["dotnet", "CreditService.Web.dll"]
