// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannelConfiguration2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnChannelConfiguration))]
  [Guid(4077606732, 30756, 18204, 161, 24, 99, 219, 201, 58, 228, 199)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnChannelConfiguration2
  {
    IVectorView<Uri> ServerUris { get; }
  }
}
