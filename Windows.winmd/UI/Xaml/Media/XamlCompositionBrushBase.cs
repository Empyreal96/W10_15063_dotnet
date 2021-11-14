// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.XamlCompositionBrushBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IXamlCompositionBrushBaseFactory), CompositionType.Protected, 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IXamlCompositionBrushBaseStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class XamlCompositionBrushBase : 
    Brush,
    IXamlCompositionBrushBase,
    IXamlCompositionBrushBaseOverrides,
    IXamlCompositionBrushBaseProtected
  {
    [MethodImpl]
    protected extern XamlCompositionBrushBase();

    public extern Color FallbackColor { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void IXamlCompositionBrushBaseOverrides.OnConnected();

    [MethodImpl]
    extern void IXamlCompositionBrushBaseOverrides.OnDisconnected();

    extern CompositionBrush IXamlCompositionBrushBaseProtected.CompositionBrush { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty FallbackColorProperty { [MethodImpl] get; }
  }
}
