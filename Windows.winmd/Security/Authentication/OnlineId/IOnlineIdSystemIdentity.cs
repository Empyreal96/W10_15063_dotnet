// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdSystemIdentity
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [Guid(1950142989, 46794, 17229, 129, 36, 83, 234, 18, 104, 83, 7)]
  [ExclusiveTo(typeof (OnlineIdSystemIdentity))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IOnlineIdSystemIdentity
  {
    OnlineIdServiceTicket Ticket { get; }

    string Id { get; }
  }
}
