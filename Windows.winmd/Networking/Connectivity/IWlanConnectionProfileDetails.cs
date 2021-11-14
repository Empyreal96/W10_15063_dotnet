// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IWlanConnectionProfileDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WlanConnectionProfileDetails))]
  [Guid(1444976843, 45914, 19441, 168, 132, 183, 85, 126, 136, 255, 134)]
  internal interface IWlanConnectionProfileDetails
  {
    string GetConnectedSsid();
  }
}
