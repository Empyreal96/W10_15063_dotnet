// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePairingRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class DevicePairingRequestedEventArgs : IDevicePairingRequestedEventArgs
  {
    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    public extern DevicePairingKinds PairingKind { [MethodImpl] get; }

    public extern string Pin { [MethodImpl] get; }

    [Overload("Accept")]
    [MethodImpl]
    public extern void Accept();

    [Overload("AcceptWithPin")]
    [MethodImpl]
    public extern void Accept(string pin);

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
