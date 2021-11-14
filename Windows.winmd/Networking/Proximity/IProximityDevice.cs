// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IProximityDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [ExclusiveTo(typeof (ProximityDevice))]
  [Guid(4020806994, 63201, 17193, 160, 252, 171, 107, 15, 210, 130, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProximityDevice
  {
    long SubscribeForMessage(string messageType, MessageReceivedHandler messageReceivedHandler);

    [Overload("PublishMessage")]
    long PublishMessage(string messageType, string message);

    [Overload("PublishMessageWithCallback")]
    long PublishMessage(
      string messageType,
      string message,
      MessageTransmittedHandler messageTransmittedHandler);

    [Overload("PublishBinaryMessage")]
    long PublishBinaryMessage(string messageType, IBuffer message);

    [Overload("PublishBinaryMessageWithCallback")]
    long PublishBinaryMessage(
      string messageType,
      IBuffer message,
      MessageTransmittedHandler messageTransmittedHandler);

    [Overload("PublishUriMessage")]
    long PublishUriMessage(Uri message);

    [Overload("PublishUriMessageWithCallback")]
    long PublishUriMessage(
      Uri message,
      MessageTransmittedHandler messageTransmittedHandler);

    void StopSubscribingForMessage(long subscriptionId);

    void StopPublishingMessage(long messageId);

    event DeviceArrivedEventHandler DeviceArrived;

    event DeviceDepartedEventHandler DeviceDeparted;

    uint MaxMessageBytes { get; }

    ulong BitsPerSecond { get; }

    string DeviceId { get; }
  }
}
