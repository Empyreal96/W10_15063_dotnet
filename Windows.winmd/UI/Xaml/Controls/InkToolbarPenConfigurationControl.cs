// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarPenConfigurationControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IInkToolbarPenConfigurationControlStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IInkToolbarPenConfigurationControlFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public class InkToolbarPenConfigurationControl : Control, IInkToolbarPenConfigurationControl
  {
    [MethodImpl]
    public extern InkToolbarPenConfigurationControl();

    public extern InkToolbarPenButton PenButton { [MethodImpl] get; }

    public static extern DependencyProperty PenButtonProperty { [MethodImpl] get; }
  }
}
