# NetworkPorts
[![Build Status](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Factions-badge.atrox.dev%2FMarkCiliaVincenti%2FNetworkPorts%2Fbadge%3Fref%3Dmaster&style=for-the-badge&label=Build)](https://actions-badge.atrox.dev/MarkCiliaVincenti/NetworkPorts/goto?ref=master) [![Nuget](https://img.shields.io/nuget/v/NetworkPorts?label=NetworkPorts&style=for-the-badge)](https://www.nuget.org/packages/NetworkPorts) [![Nuget](https://img.shields.io/nuget/dt/NetworkPorts?style=for-the-badge)](https://www.nuget.org/packages/NetworkPorts)

Constants for common network ports. Stop writing port numbers like 80 and 443 in your code and start using NetworkPort.Http and NetworkPort.Https instead.

## Installation
The recommended means is to use [NuGet](https://www.nuget.org/packages/NetworkPorts), but you could also download the source code from [here](https://github.com/MarkCiliaVincenti/NetworkPorts/releases).

## Usage
```csharp
builder.WebHost.UseKestrel(k =>
{
    k.ListenAnyIp(
        NetworkPort.Http,
        listenOptions =>
        {
            listenOptions.Protocols = HttpProtocols.Http1;
        });
    });
}
```
