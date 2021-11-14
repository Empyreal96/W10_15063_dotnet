// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattClientNotificationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattClientNotificationResult : IGattClientNotificationResult
  {
    public extern GattSubscribedClient SubscribedClient { [MethodImpl] get; }

    public extern GattCommunicationStatus Status { [MethodImpl] get; }

    public extern IReference<byte> ProtocolError { [MethodImpl] get; }
  }
}
