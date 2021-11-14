// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebProviderErrorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [Guid(3821275693, 35311, 20023, 132, 127, 168, 185, 213, 163, 41, 16)]
  [ExclusiveTo(typeof (WebProviderError))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebProviderErrorFactory
  {
    WebProviderError Create(uint errorCode, string errorMessage);
  }
}
