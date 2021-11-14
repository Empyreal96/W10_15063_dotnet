// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattWriteRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattWriteRequestedEventArgs))]
  [Guid(770476990, 42810, 18202, 148, 213, 3, 125, 234, 221, 8, 6)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattWriteRequestedEventArgs
  {
    GattSession Session { get; }

    Deferral GetDeferral();

    [RemoteAsync]
    IAsyncOperation<GattWriteRequest> GetRequestAsync();
  }
}
