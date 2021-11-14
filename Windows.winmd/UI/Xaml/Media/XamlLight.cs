// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.XamlLight
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IXamlLightFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IXamlLightStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public class XamlLight : DependencyObject, IXamlLight, IXamlLightOverrides, IXamlLightProtected
  {
    [MethodImpl]
    public extern XamlLight();

    [MethodImpl]
    extern string IXamlLightOverrides.GetId();

    [MethodImpl]
    extern void IXamlLightOverrides.OnConnected(UIElement newElement);

    [MethodImpl]
    extern void IXamlLightOverrides.OnDisconnected(UIElement oldElement);

    extern CompositionLight IXamlLightProtected.CompositionLight { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern void AddTargetElement(string lightId, UIElement element);

    [MethodImpl]
    public static extern void RemoveTargetElement(string lightId, UIElement element);

    [MethodImpl]
    public static extern void AddTargetBrush(string lightId, Brush brush);

    [MethodImpl]
    public static extern void RemoveTargetBrush(string lightId, Brush brush);
  }
}
