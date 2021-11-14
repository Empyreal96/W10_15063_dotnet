// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IHtmlFormatHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(3794696009, 56688, 17519, 174, 252, 97, 206, 229, 159, 101, 94)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HtmlFormatHelper))]
  internal interface IHtmlFormatHelperStatics
  {
    string GetStaticFragment(string htmlFormat);

    string CreateHtmlFormat(string htmlFragment);
  }
}
