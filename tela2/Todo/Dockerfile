# Use an official .NET 7.0 runtime image as the base image
FROM mcr.microsoft.com/dotnet/sdk:7.0

# Set the working directory
WORKDIR /app

# Copy the application to the working directory
COPY . .

# Restore dependencies and build the application
RUN dotnet restore
RUN dotnet build -c Release

# Set the entry point for the Docker container
ENTRYPOINT ["dotnet", "run"]