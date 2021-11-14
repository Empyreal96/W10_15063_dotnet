// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeUtil
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace System.Data.SqlServerCe
{
  internal static class SqlCeUtil
  {
    internal const string ProviderName = "SQL Server Compact ADO.NET Data Provider";
    internal const string ProductName = "Microsoft SQL Server Compact";
    internal const string ProductRootRegKey = "Software\\Microsoft\\Microsoft SQL Server Compact Edition\\v3.5";
    internal const string Product35RootRegKey = "SOFTWARE\\Microsoft\\Microsoft SQL Server Compact Edition\\v3.5";
    internal const string ProductProxyPortsRegKey = "Software\\Microsoft\\Windows CE Services\\ProxyPorts";
    internal const string NetCFKey = "Software\\Microsoft\\.NetCompactFramework\\Installer\\Assemblies\\Global";
    internal const string ProductServicingFile = "Microsoft.SqlServer.Compact.351.{0}.bc";
    internal const string ModuleStorageEngine = "sqlcese35.dll";
    internal const string ModuleStorageEngineSys = "sqlcese35.sys.dll";
    internal const string ModuleQueryProcessor = "sqlceqp35.dll";
    internal const string ModuleClientAgent = "sqlceca35.dll";
    internal const string ModuleOleDbProvider = "sqlceoledb35.dll";
    internal const string ModuleManagedExtentions = "sqlceme35.dll";
    internal const string ModuleDbCompact = "sqlcecompact35.dll";
    internal const string ModuleErrRes = "sqlceer35{0}.dll";
    internal const string ModuleServerAgent = "sqlcesa35.dll";
    internal const string ModuleReplicationProvider = "sqlcerp35.dll";
    internal const string ModuleTdsServer = "tdsserver35.exe";
    private static bool? isWebHosted;
    internal const string SqlCeModulesLocation = "\\Windows\\";

    internal static bool IsWebHosted
    {
      get
      {
        if (!SqlCeUtil.isWebHosted.HasValue)
          SqlCeUtil.isWebHosted = new bool?(SqlCeUtil.FindIfWebHosted());
        return SqlCeUtil.isWebHosted.Value;
      }
    }

    private static bool FindIfWebHosted() => false;
  }
}
