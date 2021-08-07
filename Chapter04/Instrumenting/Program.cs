using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write to a file called log.txt in the project folder.
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));

            // Flushes text from buffer to file after each write (default is when buffer is full)
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug is watching.");
            Trace.WriteLine("Trace is watching.");

            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json",
            optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var ts = new TraceSwitch(displayName: "TraceSwitch", "This switch is set via a JSON configuration.");
            configuration.GetSection("TraceSwitch").Bind(ts);

            Trace.WriteLineIf(ts.TraceError, "Trace error.");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning.");
            Trace.WriteLineIf(ts.TraceInfo, "Trace info.");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose.");
            
        }
    }
}
