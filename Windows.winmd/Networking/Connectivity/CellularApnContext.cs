// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.CellularApnContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CellularApnContext : ICellularApnContext
  {
    [MethodImpl]
    public extern CellularApnContext();

    public extern string ProviderId { [MethodImpl] get; [MethodImpl] set; }

    public extern string AccessPointName { [MethodImpl] get; [MethodImpl] set; }

    public extern string UserName { [MethodImpl] get; [MethodImpl] set; }

    public extern string Password { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCompressionEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern CellularApnAuthenticationType AuthenticationType { [MethodImpl] get; [MethodImpl] set; }
  }
}
