// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.SelectorItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Composable(typeof (ISelectorItemFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISelectorItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class SelectorItem : ContentControl, ISelectorItem
  {
    [MethodImpl]
    protected extern SelectorItem();

    public extern bool IsSelected { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IsSelectedProperty { [MethodImpl] get; }
  }
}
