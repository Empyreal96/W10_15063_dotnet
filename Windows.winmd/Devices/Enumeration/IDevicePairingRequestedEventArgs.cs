// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePairingRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (DevicePairingRequestedEventArgs))]
  [Guid(4145544278, 56939, 18559, 131, 118, 1, 128, 172, 166, 153, 99)]
  internal interface IDevicePairingRequestedEventArgs
  {
    DeviceInformation DeviceInformation { get; }

    DevicePairingKinds PairingKind { get; }

    string Pin { get; }

    [Overload("Accept")]
    void Accept();

    [Overload("AcceptWithPin")]
    void Accept(string pin);

    Deferral GetDeferral();
  }
}
