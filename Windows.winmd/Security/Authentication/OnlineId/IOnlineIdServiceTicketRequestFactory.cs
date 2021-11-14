// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicketRequestFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (OnlineIdServiceTicketRequest))]
  [Guid(3199928840, 40563, 16503, 150, 20, 8, 97, 76, 11, 194, 69)]
  internal interface IOnlineIdServiceTicketRequestFactory
  {
    OnlineIdServiceTicketRequest CreateOnlineIdServiceTicketRequest(
      string service,
      string policy);

    OnlineIdServiceTicketRequest CreateOnlineIdServiceTicketRequestAdvanced(
      string service);
  }
}
