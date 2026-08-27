# Using the .net core's base Image S1
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS base

#Specifying the current directory
WORKDIR /app

#telling on which port the app listens
EXPOSE 5151

# Next stage to build  S2
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

#Create a new directory again
WORKDIR /src

#Dependencies are coming from ..csproj to current src
COPY ["..csproj","."]

#Installing all the dependencies from ..csproj
RUN dotnet restore "./..csproj"

#Copy everything into the current /src except the ignored files 
COPY . .

#Create a new directory again
WORKDIR "/src/."
RUN dotnet build "..csproj" -c Release -o /app/build /p:UseAppHost=false

# S3
FROM build AS publish 
RUN dotnet publish "..csproj" -c Release -o /app/publish /p:UseAppHost=false

# S4
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet","..dll"]









