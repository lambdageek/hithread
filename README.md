## Browser application with threading

## Prerequisites

This demo requires .NET 7 Release Candidate 2 or later and the `wasm-experimental` workload.

```
dotnet workload install wasm-experimental
```

This sample is a modified copy of the `dotnet new wasmbrowser` template. It is recommended to start
your own projects using the template, not by cloning this sample.


## Build

You can build the applcation from Visual Studio or the dotnet cli

```
dotnet build -c Debug/Release -r browser-wasm
```

After building the application, the result is in the `bin/$(Configuration)/net7.0/browser-wasm/AppBundle` directory.

## Run

You can build the applcation from Visual Studio or the dotnet cli

```
dotnet run -c Debug/Release -r browser-wasm
```

Or you can start any static file server from the AppBundle directory

```
dotnet serve -h "Cross-Origin-Opener-Policy:same-origin" -h "Cross-Origin-Embedder-Policy:require-corp" -d:bin/$(Configuration)/net7.0/browser-wasm/AppBundle
```

Note that to use threading the web server must send [cross-origin isolation headers](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/SharedArrayBuffer#security_requirements).



