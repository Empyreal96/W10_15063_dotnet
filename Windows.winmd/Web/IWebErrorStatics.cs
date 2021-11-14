// Decompiled with JetBrains decompiler
// Type: Windows.Web.IWebErrorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web
{
  [Guid(4267796326, 48935, 16484, 135, 183, 101, 99, 187, 17, 206, 46)]
  [ExclusiveTo(typeof (WebError))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebErrorStatics
  {
    WebErrorStatus GetStatus(int hresult);
  }
}
