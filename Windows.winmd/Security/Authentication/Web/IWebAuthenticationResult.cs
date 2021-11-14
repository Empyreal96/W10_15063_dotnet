// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.IWebAuthenticationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  [Guid(1677732683, 60905, 18186, 165, 205, 3, 35, 250, 246, 226, 98)]
  [ExclusiveTo(typeof (WebAuthenticationResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAuthenticationResult
  {
    string ResponseData { get; }

    WebAuthenticationStatus ResponseStatus { get; }

    uint ResponseErrorDetail { get; }
  }
}
