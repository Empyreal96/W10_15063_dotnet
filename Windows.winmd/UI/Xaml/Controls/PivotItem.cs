// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PivotItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IPivotItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IPivotItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class PivotItem : ContentControl, IPivotItem
  {
    [MethodImpl]
    public extern PivotItem();

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }
  }
}
