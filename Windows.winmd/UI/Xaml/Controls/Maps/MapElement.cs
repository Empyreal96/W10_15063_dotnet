// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Static(typeof (IMapElementStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IMapElementFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class MapElement : DependencyObject, IMapElement, IMapElement2
  {
    [MethodImpl]
    public extern MapElement();

    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Visible { [MethodImpl] get; [MethodImpl] set; }

    public extern int MapTabIndex { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty MapTabIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty ZIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty VisibleProperty { [MethodImpl] get; }
  }
}
