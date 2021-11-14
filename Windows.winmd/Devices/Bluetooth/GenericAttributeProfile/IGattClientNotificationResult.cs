// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattClientNotificationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattClientNotificationResult))]
  [Guid(1349342617, 274, 16794, 142, 59, 174, 33, 175, 171, 210, 194)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattClientNotificationResult
  {
    GattSubscribedClient SubscribedClient { get; }

    GattCommunicationStatus Status { get; }

    IReference<byte> ProtocolError { get; }
  }
}
