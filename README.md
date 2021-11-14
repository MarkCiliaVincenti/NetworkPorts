# NetworkPorts
Constants for common network ports. Stop writing port numbers like 80 and 443 in your code and start using NetworkPort.Http and NetworkPort.Https instead.

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