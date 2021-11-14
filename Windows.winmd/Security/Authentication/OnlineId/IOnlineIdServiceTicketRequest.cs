// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicketRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [Guid(695485907, 64355, 16693, 137, 9, 78, 53, 76, 6, 20, 102)]
  [ExclusiveTo(typeof (OnlineIdServiceTicketRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOnlineIdServiceTicketRequest
  {
    string Service { get; }

    string Policy { get; }
  }
}
