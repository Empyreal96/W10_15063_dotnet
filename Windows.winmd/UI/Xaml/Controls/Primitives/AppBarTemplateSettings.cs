// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.AppBarTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AppBarTemplateSettings : DependencyObject, IAppBarTemplateSettings
  {
    public extern Rect ClipRect { [MethodImpl] get; }

    public extern double CompactVerticalDelta { [MethodImpl] get; }

    public extern Thickness CompactRootMargin { [MethodImpl] get; }

    public extern double MinimalVerticalDelta { [MethodImpl] get; }

    public extern Thickness MinimalRootMargin { [MethodImpl] get; }

    public extern double HiddenVerticalDelta { [MethodImpl] get; }

    public extern Thickness HiddenRootMargin { [MethodImpl] get; }
  }
}
