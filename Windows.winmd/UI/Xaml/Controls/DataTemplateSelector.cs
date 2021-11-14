// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DataTemplateSelector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IDataTemplateSelectorFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class DataTemplateSelector : 
    IDataTemplateSelector,
    IDataTemplateSelectorOverrides,
    IDataTemplateSelector2,
    IDataTemplateSelectorOverrides2
  {
    [MethodImpl]
    public extern DataTemplateSelector();

    [MethodImpl]
    public extern DataTemplate SelectTemplate(object item, DependencyObject container);

    [MethodImpl]
    extern DataTemplate IDataTemplateSelectorOverrides.SelectTemplateCore(
      object item,
      DependencyObject container);

    [Overload("SelectTemplateForItem")]
    [MethodImpl]
    public extern DataTemplate SelectTemplate(object item);

    [Overload("SelectTemplateForItemCore")]
    [MethodImpl]
    extern DataTemplate IDataTemplateSelectorOverrides2.SelectTemplateCore(
      object item);
  }
}
