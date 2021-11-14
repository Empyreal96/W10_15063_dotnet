// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.HidGameControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  public sealed class HidGameControllerProvider : IHidGameControllerProvider, IGameControllerProvider
  {
    public extern ushort UsageId { [MethodImpl] get; }

    public extern ushort UsagePage { [MethodImpl] get; }

    [MethodImpl]
    public extern void GetFeatureReport(byte reportId, [Out] byte[] reportBuffer);

    [MethodImpl]
    public extern void SendFeatureReport(byte reportId, byte[] reportBuffer);

    [MethodImpl]
    public extern void SendOutputReport(byte reportId, byte[] reportBuffer);

    public extern GameControllerVersionInfo FirmwareVersionInfo { [MethodImpl] get; }

    public extern ushort HardwareProductId { [MethodImpl] get; }

    public extern ushort HardwareVendorId { [MethodImpl] get; }

    public extern GameControllerVersionInfo HardwareVersionInfo { [MethodImpl] get; }

    public extern bool IsConnected { [MethodImpl] get; }
  }
}
