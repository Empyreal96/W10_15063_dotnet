// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdSystemTicketResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [ExclusiveTo(typeof (OnlineIdSystemTicketResult))]
  [Guid(3674890232, 45208, 19149, 157, 19, 158, 100, 6, 82, 181, 182)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IOnlineIdSystemTicketResult
  {
    OnlineIdSystemIdentity Identity { get; }

    OnlineIdSystemTicketStatus Status { get; }

    HResult ExtendedError { get; }
  }
}
