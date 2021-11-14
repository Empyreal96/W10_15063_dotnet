// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [ExclusiveTo(typeof (PeerInformation))]
  [Guid(537022216, 40959, 17908, 182, 233, 64, 139, 46, 190, 243, 115)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPeerInformation
  {
    string DisplayName { get; }
  }
}
