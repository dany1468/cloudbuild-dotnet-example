FROM mcr.microsoft.com/dotnet/core/sdk:3.1 
COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]
RUN ["dotnet", "tool", "restore"]
RUN ["dotnet", "build"]
RUN chmod +x ./entrypoint.sh
