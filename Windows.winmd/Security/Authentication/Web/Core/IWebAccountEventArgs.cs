// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAccountEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (WebAccountEventArgs))]
  [Guid(1874264957, 16974, 17644, 151, 124, 239, 36, 21, 70, 42, 90)]
  internal interface IWebAccountEventArgs
  {
    WebAccount Account { get; }
  }
}
