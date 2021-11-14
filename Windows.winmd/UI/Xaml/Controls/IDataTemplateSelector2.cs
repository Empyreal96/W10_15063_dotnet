// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDataTemplateSelector2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (DataTemplateSelector))]
  [WebHostHidden]
  [Guid(932363335, 35915, 16983, 165, 174, 204, 63, 142, 215, 134, 235)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataTemplateSelector2
  {
    [Overload("SelectTemplateForItem")]
    DataTemplate SelectTemplate(object item);
  }
}
