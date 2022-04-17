//QmlExample.cs
using Qml.Net;
using Qml.Net.Runtimes;

namespace AquaDRPCE
{
    class QmlExample
    {
        static int Main(string[] args)
        {
            RuntimeManager.DiscoverOrDownloadSuitableQtRuntime();
            using (var app = new QGuiApplication(args))
            {
                using (var engine = new QQmlApplicationEngine())
                {
                    // Register our new type to be used in Qml
                    Qml.Net.Qml.RegisterType<QmlType>("DRPCE", 1, 1);
                    engine.Load("Main.qml");
                    return app.Exec();
                }
            }
        }
    }
}