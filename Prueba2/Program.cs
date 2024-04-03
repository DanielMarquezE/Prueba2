// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Prueba2.UpdatePackageSample modelo = new Prueba2.UpdatePackageSample();
modelo.monitorFilesLocation="C:\\Users\\dani_\\Desktop\\Carpeta 1";
modelo.installationFolder="C:\\Users\\dani_\\Desktop\\Carpeta 2";
modelo.Version="1.0";
Prueba2.MonitorUpdaterManagerSample.UpdateMonitor(modelo);