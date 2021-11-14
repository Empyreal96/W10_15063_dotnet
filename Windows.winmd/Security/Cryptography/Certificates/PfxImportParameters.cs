// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.PfxImportParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class PfxImportParameters : IPfxImportParameters
  {
    [MethodImpl]
    public extern PfxImportParameters();

    public extern ExportOption Exportable { [MethodImpl] get; [MethodImpl] set; }

    public extern KeyProtectionLevel KeyProtectionLevel { [MethodImpl] get; [MethodImpl] set; }

    public extern InstallOptions InstallOptions { [MethodImpl] get; [MethodImpl] set; }

    public extern string FriendlyName { [MethodImpl] get; [MethodImpl] set; }

    public extern string KeyStorageProviderName { [MethodImpl] get; [MethodImpl] set; }

    public extern string ContainerNamePrefix { [MethodImpl] get; [MethodImpl] set; }

    public extern string ReaderName { [MethodImpl] get; [MethodImpl] set; }
  }
}
