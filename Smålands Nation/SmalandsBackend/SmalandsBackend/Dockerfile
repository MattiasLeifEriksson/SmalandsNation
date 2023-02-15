# Use the latest Microsoft .NET Core SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS base

# Set the working directory
WORKDIR /app

# Copy the project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore --source https://api.nuget.org/v3/index.json

# Copy the rest of the code and build the application
COPY . ./
RUN dotnet build -c Release

# Use the built application as the final image
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=base /app/bin/Release/net5.0 /app

# Set the command to run the application
CMD ["dotnet", "SmalandsBackend.dll"]
#ENTRYPOINT ["dotnet", "SmalandsBackend.dll"]


#docker build -t myapi .
#docker run -p 5000:80 myapi
