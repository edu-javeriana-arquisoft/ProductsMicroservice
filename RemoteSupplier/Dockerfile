FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /Application

COPY ../Protos/ ./Protos
COPY ../RemoteSupplier/ ./RemoteSupplier

WORKDIR /Application/RemoteSupplier

RUN dotnet restore
RUN dotnet publish -c Release
RUN dotnet tool install --global dotnet-ef --version 7.0.14

ENV PATH "$PATH:/root/.dotnet/tools"

ARG PORT=5901
EXPOSE $PORT

WORKDIR /Application/RemoteSupplier

ENTRYPOINT ["/bin/bash"]
CMD ["entrypoint.sh"]

