// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountClientViewFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(1634539172, 56866, 18517, 163, 38, 6, 206, 191, 42, 63, 35)]
  [ExclusiveTo(typeof (WebAccountClientView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountClientViewFactory
  {
    WebAccountClientView Create(
      WebAccountClientViewType viewType,
      Uri applicationCallbackUri);

    WebAccountClientView CreateWithPairwiseId(
      WebAccountClientViewType viewType,
      Uri applicationCallbackUri,
      string accountPairwiseId);
  }
}
