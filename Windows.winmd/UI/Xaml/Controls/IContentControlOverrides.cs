// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentControlOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ContentControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1598819088, 58254, 19293, 190, 26, 94, 208, 66, 70, 166, 53)]
  internal interface IContentControlOverrides
  {
    void OnContentChanged(object oldContent, object newContent);

    void OnContentTemplateChanged(DataTemplate oldContentTemplate, DataTemplate newContentTemplate);

    void OnContentTemplateSelectorChanged(
      DataTemplateSelector oldContentTemplateSelector,
      DataTemplateSelector newContentTemplateSelector);
  }
}
