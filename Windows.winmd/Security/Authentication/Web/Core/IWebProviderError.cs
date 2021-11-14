// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebProviderError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [ExclusiveTo(typeof (WebProviderError))]
  [Guid(3675855793, 20677, 18441, 141, 202, 9, 201, 148, 16, 36, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebProviderError
  {
    uint ErrorCode { get; }

    string ErrorMessage { get; }

    IMap<string, string> Properties { get; }
  }
}
