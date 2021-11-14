// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicket
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [Guid(3378271359, 55169, 19092, 172, 184, 197, 152, 116, 35, 140, 38)]
  [ExclusiveTo(typeof (OnlineIdServiceTicket))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOnlineIdServiceTicket
  {
    string Value { get; }

    OnlineIdServiceTicketRequest Request { get; }

    int ErrorCode { get; }
  }
}
