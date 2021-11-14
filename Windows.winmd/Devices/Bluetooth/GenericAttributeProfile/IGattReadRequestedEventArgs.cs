// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattReadRequestedEventArgs))]
  [Guid(2471064131, 62364, 18507, 138, 182, 153, 107, 164, 134, 207, 163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattReadRequestedEventArgs
  {
    GattSession Session { get; }

    Deferral GetDeferral();

    [RemoteAsync]
    IAsyncOperation<GattReadRequest> GetRequestAsync();
  }
}
