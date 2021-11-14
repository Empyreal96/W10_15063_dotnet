// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IDevicePairingActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3953185252, 60614, 16712, 148, 237, 244, 179, 126, 192, 91, 62)]
  public interface IDevicePairingActivatedEventArgs : IActivatedEventArgs
  {
    DeviceInformation DeviceInformation { get; }
  }
}
