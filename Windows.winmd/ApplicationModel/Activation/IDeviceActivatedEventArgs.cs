// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IDeviceActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(3444619689, 52752, 17618, 130, 52, 195, 85, 160, 115, 239, 51)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IDeviceActivatedEventArgs : IActivatedEventArgs
  {
    string DeviceInformationId { get; }

    string Verb { get; }
  }
}
