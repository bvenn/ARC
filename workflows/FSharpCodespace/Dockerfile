FROM fsharp:netcore

# Copy endpoint specific user settings into container to specify
# .NET Core should be used as the runtime.
COPY .devcontainer/settings.vscode.json /root/.vscode-remote/data/Machine/settings.json

# Install git, process tools
RUN apt-get update && apt-get -y install git procps

WORKDIR /workspaces/FSharpCodespace/dependencies

RUN dotnet new tool-manifest 
RUN dotnet tool install paket --version 5.251.0
RUN dotnet paket init
RUN dotnet paket add Plotly.NET --version 2.0.0-alpha3
#RUN dotnet paket add FSharpAux --version 1.0.0
#RUN dotnet paket add FSharp.Stats --version 0.3.0-beta
#RUN dotnet paket add BioFSharp --version 2.0.0-beta4
RUN dotnet paket generate-load-scripts --framework netstandard2.0 --type fsx
