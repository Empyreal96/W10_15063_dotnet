// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnSystemHealth
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Vpn
{
  [Guid(2577987759, 49390, 20085, 129, 122, 242, 49, 174, 229, 18, 61)]
  [ExclusiveTo(typeof (VpnSystemHealth))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnSystemHealth
  {
    Buffer StatementOfHealth { get; }
  }
}
