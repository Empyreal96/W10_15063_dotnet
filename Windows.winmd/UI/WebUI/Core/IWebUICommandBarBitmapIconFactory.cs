// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.Core.IWebUICommandBarBitmapIconFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI.Core
{
  [Guid(4093106058, 30323, 17482, 190, 98, 172, 18, 211, 28, 34, 49)]
  [ContractVersion(typeof (WebUICommandBarContract), 65536)]
  [ExclusiveTo(typeof (WebUICommandBarBitmapIcon))]
  internal interface IWebUICommandBarBitmapIconFactory
  {
    WebUICommandBarBitmapIcon Create(Uri uri);
  }
}
