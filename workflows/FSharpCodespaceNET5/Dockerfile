FROM mcr.microsoft.com/dotnet/sdk:5.0

# Copy endpoint specific user settings into container to specify
# .NET Core should be used as the runtime.
COPY .devcontainer/settings.vscode.json /root/.vscode-remote/data/Machine/settings.json

# Install git, process tools
RUN apt-get update && apt-get -y install git procps
