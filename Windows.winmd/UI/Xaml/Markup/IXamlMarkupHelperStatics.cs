// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlMarkupHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  [Guid(3384555301, 62287, 17500, 129, 162, 107, 114, 165, 232, 240, 114)]
  [ExclusiveTo(typeof (XamlMarkupHelper))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IXamlMarkupHelperStatics
  {
    void UnloadObject(DependencyObject element);
  }
}
