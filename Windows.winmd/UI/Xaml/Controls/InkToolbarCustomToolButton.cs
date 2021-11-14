// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarCustomToolButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Composable(typeof (IInkToolbarCustomToolButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IInkToolbarCustomToolButtonStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public class InkToolbarCustomToolButton : InkToolbarToolButton, IInkToolbarCustomToolButton
  {
    [MethodImpl]
    public extern InkToolbarCustomToolButton();

    public extern UIElement ConfigurationContent { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ConfigurationContentProperty { [MethodImpl] get; }
  }
}
