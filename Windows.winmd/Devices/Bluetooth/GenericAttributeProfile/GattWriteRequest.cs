// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattWriteRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattWriteRequest : IGattWriteRequest
  {
    public extern IBuffer Value { [MethodImpl] get; }

    public extern uint Offset { [MethodImpl] get; }

    public extern GattWriteOption Option { [MethodImpl] get; }

    public extern GattRequestState State { [MethodImpl] get; }

    public extern event TypedEventHandler<GattWriteRequest, GattRequestStateChangedEventArgs> StateChanged;

    [MethodImpl]
    public extern void Respond();

    [MethodImpl]
    public extern void RespondWithProtocolError(byte protocolError);
  }
}
