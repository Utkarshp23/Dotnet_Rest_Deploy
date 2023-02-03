FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /Rest_Api

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /Rest_Api
COPY --from=build-env /Rest_Api/out .
ENTRYPOINT ["dotnet", "Rest_Api.dll"]