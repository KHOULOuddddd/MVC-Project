FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:5000
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MVC Project/MVC Project.csproj", "MVC Project/"]
RUN dotnet restore "MVC Project/MVC Project.csproj"
COPY . .
WORKDIR "/src/MVC Project"
RUN dotnet build "MVC Project.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "MVC Project.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MVC Project.dll"]

