// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.CommandBarTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class CommandBarTemplateSettings : 
    DependencyObject,
    ICommandBarTemplateSettings,
    ICommandBarTemplateSettings2,
    ICommandBarTemplateSettings3
  {
    public extern double ContentHeight { [MethodImpl] get; }

    public extern Rect OverflowContentClipRect { [MethodImpl] get; }

    public extern double OverflowContentMinWidth { [MethodImpl] get; }

    public extern double OverflowContentMaxHeight { [MethodImpl] get; }

    public extern double OverflowContentHorizontalOffset { [MethodImpl] get; }

    public extern double OverflowContentHeight { [MethodImpl] get; }

    public extern double NegativeOverflowContentHeight { [MethodImpl] get; }

    public extern double OverflowContentMaxWidth { [MethodImpl] get; }

    public extern Visibility EffectiveOverflowButtonVisibility { [MethodImpl] get; }
  }
}
