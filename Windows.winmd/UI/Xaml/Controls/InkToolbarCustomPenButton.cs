// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarCustomPenButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IInkToolbarCustomPenButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IInkToolbarCustomPenButtonStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public class InkToolbarCustomPenButton : InkToolbarPenButton, IInkToolbarCustomPenButton
  {
    [MethodImpl]
    public extern InkToolbarCustomPenButton();

    public extern InkToolbarCustomPen CustomPen { [MethodImpl] get; [MethodImpl] set; }

    public extern UIElement ConfigurationContent { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty CustomPenProperty { [MethodImpl] get; }

    public static extern DependencyProperty ConfigurationContentProperty { [MethodImpl] get; }
  }
}
