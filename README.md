# NetworkPorts
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