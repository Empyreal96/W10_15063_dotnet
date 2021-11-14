// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.CoreApplicationViewTitleBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [WebHostHidden]
  [Muse(Version = 167772160)]
  public sealed class CoreApplicationViewTitleBar : ICoreApplicationViewTitleBar
  {
    public extern bool ExtendViewIntoTitleBar { [MethodImpl] set; [MethodImpl] get; }

    public extern double SystemOverlayLeftInset { [MethodImpl] get; }

    public extern double SystemOverlayRightInset { [MethodImpl] get; }

    public extern double Height { [MethodImpl] get; }

    public extern event TypedEventHandler<CoreApplicationViewTitleBar, object> LayoutMetricsChanged;

    public extern bool IsVisible { [MethodImpl] get; }

    public extern event TypedEventHandler<CoreApplicationViewTitleBar, object> IsVisibleChanged;
  }
}
