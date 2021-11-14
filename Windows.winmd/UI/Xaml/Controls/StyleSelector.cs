// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.StyleSelector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Composable(typeof (IStyleSelectorFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class StyleSelector : IStyleSelector, IStyleSelectorOverrides
  {
    [MethodImpl]
    public extern StyleSelector();

    [MethodImpl]
    public extern Style SelectStyle(object item, DependencyObject container);

    [MethodImpl]
    extern Style IStyleSelectorOverrides.SelectStyleCore(
      object item,
      DependencyObject container);
  }
}
