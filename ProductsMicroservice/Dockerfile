FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /Application

COPY ../Protos/ ./Protos
COPY ../ProductsMicroservice/ ./ProductsMicroservice

WORKDIR /Application/ProductsMicroservice

RUN dotnet restore
RUN dotnet publish -c Release

ARG PORT=5911
EXPOSE $PORT

WORKDIR /Application/ProductsMicroservice
ENTRYPOINT ["./bin/Release/net7.0/ProductsMicroservice"]

