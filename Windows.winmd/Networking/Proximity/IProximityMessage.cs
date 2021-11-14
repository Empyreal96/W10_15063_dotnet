// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IProximityMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [Guid(4020963202, 63201, 18037, 160, 69, 216, 227, 32, 194, 72, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProximityMessage))]
  internal interface IProximityMessage
  {
    string MessageType { get; }

    long SubscriptionId { get; }

    IBuffer Data { get; }

    string DataAsString { get; }
  }
}
