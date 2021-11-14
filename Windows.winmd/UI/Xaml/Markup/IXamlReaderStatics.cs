// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlReaderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  [ExclusiveTo(typeof (XamlReader))]
  [Guid(2559690429, 21327, 18773, 184, 90, 138, 141, 192, 220, 166, 2)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IXamlReaderStatics
  {
    object Load(string xaml);

    object LoadWithInitialTemplateValidation(string xaml);
  }
}
