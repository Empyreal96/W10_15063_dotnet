// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.ProximityDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [Static(typeof (IProximityDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  public sealed class ProximityDevice : IProximityDevice
  {
    [MethodImpl]
    public extern long SubscribeForMessage(
      string messageType,
      MessageReceivedHandler messageReceivedHandler);

    [Overload("PublishMessage")]
    [MethodImpl]
    public extern long PublishMessage(string messageType, string message);

    [Overload("PublishMessageWithCallback")]
    [MethodImpl]
    public extern long PublishMessage(
      string messageType,
      string message,
      MessageTransmittedHandler messageTransmittedHandler);

    [Overload("PublishBinaryMessage")]
    [MethodImpl]
    public extern long PublishBinaryMessage(string messageType, IBuffer message);

    [Overload("PublishBinaryMessageWithCallback")]
    [MethodImpl]
    public extern long PublishBinaryMessage(
      string messageType,
      IBuffer message,
      MessageTransmittedHandler messageTransmittedHandler);

    [Overload("PublishUriMessage")]
    [MethodImpl]
    public extern long PublishUriMessage(Uri message);

    [Overload("PublishUriMessageWithCallback")]
    [MethodImpl]
    public extern long PublishUriMessage(
      Uri message,
      MessageTransmittedHandler messageTransmittedHandler);

    [MethodImpl]
    public extern void StopSubscribingForMessage(long subscriptionId);

    [MethodImpl]
    public extern void StopPublishingMessage(long messageId);

    public extern event DeviceArrivedEventHandler DeviceArrived;

    public extern event DeviceDepartedEventHandler DeviceDeparted;

    public extern uint MaxMessageBytes { [MethodImpl] get; }

    public extern ulong BitsPerSecond { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [MethodImpl]
    public static extern ProximityDevice GetDefault();

    [MethodImpl]
    public static extern ProximityDevice FromId(string deviceId);
  }
}
