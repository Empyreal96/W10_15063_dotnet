// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattWriteRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(2931206637, 56879, 20418, 169, 168, 148, 234, 120, 68, 241, 61)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattWriteRequest))]
  internal interface IGattWriteRequest
  {
    IBuffer Value { get; }

    uint Offset { get; }

    GattWriteOption Option { get; }

    GattRequestState State { get; }

    event TypedEventHandler<GattWriteRequest, GattRequestStateChangedEventArgs> StateChanged;

    void Respond();

    void RespondWithProtocolError(byte protocolError);
  }
}
