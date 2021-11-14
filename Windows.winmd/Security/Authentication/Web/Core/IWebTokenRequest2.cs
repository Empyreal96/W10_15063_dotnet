// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenRequest2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [Guid(3607150713, 12488, 17303, 150, 84, 150, 28, 59, 232, 184, 85)]
  [ExclusiveTo(typeof (WebTokenRequest))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IWebTokenRequest2
  {
    IMap<string, string> AppProperties { get; }
  }
}
