# Imagen base para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

# Imagen para compilar
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiamos el archivo .csproj y restauramos dependencias
COPY ["NatureApi2.csproj", "./"]
RUN dotnet restore "./NatureApi2.csproj"

# Copiamos todo el código fuente
COPY . .

# Compilamos la aplicación
RUN dotnet build "NatureApi2.csproj" -c Release -o /app/build

# Publicamos la aplicación (listo para producción)
FROM build AS publish
RUN dotnet publish "NatureApi2.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Imagen final: liviana
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Comando para ejecutar la app
ENTRYPOINT ["dotnet", "NatureApi2.dll"]
