// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.CoreApplicationView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.ApplicationModel.Core
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  public sealed class CoreApplicationView : 
    ICoreApplicationView,
    ICoreApplicationView2,
    ICoreApplicationView3,
    ICoreApplicationView5
  {
    public extern CoreWindow CoreWindow { [MethodImpl] get; }

    public extern event TypedEventHandler<CoreApplicationView, IActivatedEventArgs> Activated;

    public extern bool IsMain { [MethodImpl] get; }

    public extern bool IsHosted { [MethodImpl] get; }

    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    public extern bool IsComponent { [MethodImpl] get; }

    public extern CoreApplicationViewTitleBar TitleBar { [MethodImpl] get; }

    public extern event TypedEventHandler<CoreApplicationView, HostedViewClosingEventArgs> HostedViewClosing;

    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
