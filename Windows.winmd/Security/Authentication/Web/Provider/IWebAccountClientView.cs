// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountClientView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3887949498, 3015, 19558, 191, 212, 101, 211, 8, 44, 188, 168)]
  [ExclusiveTo(typeof (WebAccountClientView))]
  internal interface IWebAccountClientView
  {
    Uri ApplicationCallbackUri { get; }

    WebAccountClientViewType Type { get; }

    string AccountPairwiseId { get; }
  }
}
