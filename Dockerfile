# Choose a base image that has the .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Install Chrome
RUN apt-get update && \
    apt-get install -y wget gnupg && \
    wget -q -O - https://dl.google.com/linux/linux_signing_key.pub | gpg --dearmor > /usr/share/keyrings/google-chrome.gpg && \
    sh -c 'echo "deb [arch=amd64 signed-by=/usr/share/keyrings/google-chrome.gpg] http://dl.google.com/linux/chrome/deb/ stable main" > /etc/apt/sources.list.d/google-chrome.list' && \
    apt-get update && \
    apt-get install -y google-chrome-stable && \
    rm -rf /var/lib/apt/lists/*

# Create a directory
WORKDIR /app

# Copy the project files to the container
COPY . /app

# Restore NuGet dependencies
RUN dotnet restore

# Compile the project
RUN dotnet build --configuration Release --no-restore