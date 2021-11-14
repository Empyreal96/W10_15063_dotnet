// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenterOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2808297965, 13055, 17291, 170, 213, 29, 104, 250, 233, 52, 38)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentPresenter))]
  internal interface IContentPresenterOverrides
  {
    void OnContentTemplateChanged(DataTemplate oldContentTemplate, DataTemplate newContentTemplate);

    void OnContentTemplateSelectorChanged(
      DataTemplateSelector oldContentTemplateSelector,
      DataTemplateSelector newContentTemplateSelector);
  }
}
