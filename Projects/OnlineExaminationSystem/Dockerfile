# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the solution and project files to the container
COPY OnlineExaminationSystem.sln ./
COPY OnlineExaminationSystem.csproj ./

# Restore dependencies
RUN dotnet restore

# Copy the rest of the application code (app source files)
COPY . ./

# Set the working directory to the project folder
WORKDIR /app

# Publish the app in Release mode
RUN dotnet publish -c Release -o out

# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory inside the runtime container
WORKDIR /app

# Copy the published application from the build stage
COPY --from=build /app/out ./

# Expose the port your app listens on (adjust as needed)
EXPOSE 8080

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "OnlineExaminationSystem.dll"]
