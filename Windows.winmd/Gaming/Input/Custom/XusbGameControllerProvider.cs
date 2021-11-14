// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.XusbGameControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class XusbGameControllerProvider : 
    IXusbGameControllerProvider,
    IGameControllerProvider
  {
    [MethodImpl]
    public extern void SetVibration(double lowFrequencyMotorSpeed, double highFrequencyMotorSpeed);

    public extern GameControllerVersionInfo FirmwareVersionInfo { [MethodImpl] get; }

    public extern ushort HardwareProductId { [MethodImpl] get; }

    public extern ushort HardwareVendorId { [MethodImpl] get; }

    public extern GameControllerVersionInfo HardwareVersionInfo { [MethodImpl] get; }

    public extern bool IsConnected { [MethodImpl] get; }
  }
}
