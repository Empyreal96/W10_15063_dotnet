// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IConnectionRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [ExclusiveTo(typeof (ConnectionRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3949498798, 20254, 19558, 189, 13, 70, 146, 74, 148, 46, 8)]
  internal interface IConnectionRequestedEventArgs
  {
    PeerInformation PeerInformation { get; }
  }
}
