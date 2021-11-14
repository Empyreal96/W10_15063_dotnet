// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebProviderTokenResponse
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IWebProviderTokenResponseFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WebProviderTokenResponse : IWebProviderTokenResponse
  {
    [MethodImpl]
    public extern WebProviderTokenResponse(WebTokenResponse webTokenResponse);

    public extern WebTokenResponse ClientResponse { [MethodImpl] get; }
  }
}
