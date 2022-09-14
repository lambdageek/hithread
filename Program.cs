using System;
using System.Threading;
using System.Runtime.Versioning;
using System.Runtime.InteropServices.JavaScript;

[assembly:SupportedOSPlatform("browser")]

new Thread(SecondThread).Start();
Console.WriteLine($"Hello, Browser from the main thread {Thread.CurrentThread.ManagedThreadId}");

static void SecondThread() {
    Console.WriteLine ($"Hello from Thread {Thread.CurrentThread.ManagedThreadId}");
    for (int i = 0; i < 5; ++i) {
	Console.WriteLine ($"Ping {i}");
        Thread.Sleep (100);
    }
}
