# Build da imagem
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY ./out .
ENTRYPOINT ["dotnet", "Temperature.Converter.API.dll"]