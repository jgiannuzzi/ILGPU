FROM gitpod/workspace-full:latest

USER gitpod

# Install .NET Core 3.1 SDK binaries on Ubuntu 20.04
RUN mkdir -p /home/gitpod/dotnet && curl -fsSL https://download.visualstudio.microsoft.com/download/pr/5de23f6d-648c-455b-a7a9-d11c9a5bca40/4836262466f2d288e8ad8647944d062f/dotnet-sdk-3.1.405-linux-x64.tar.gz | tar xz -C /home/gitpod/dotnet
ENV DOTNET_ROOT=/home/gitpod/dotnet
ENV PATH=$PATH:/home/gitpod/dotnet
