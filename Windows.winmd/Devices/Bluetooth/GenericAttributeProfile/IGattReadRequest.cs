// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattReadRequest))]
  [Guid(4057818421, 27341, 17062, 164, 187, 215, 137, 218, 224, 4, 62)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattReadRequest
  {
    uint Offset { get; }

    uint Length { get; }

    GattRequestState State { get; }

    event TypedEventHandler<GattReadRequest, GattRequestStateChangedEventArgs> StateChanged;

    void RespondWithValue(IBuffer value);

    void RespondWithProtocolError(byte protocolError);
  }
}
