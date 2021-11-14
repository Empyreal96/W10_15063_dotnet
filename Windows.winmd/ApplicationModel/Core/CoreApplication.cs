// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.CoreApplication
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [Static(typeof (ICoreApplicationUnhandledError), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreImmersiveApplication2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (ICoreApplicationUseCount), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreImmersiveApplication), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreApplication), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICoreApplicationExit), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [Static(typeof (ICoreImmersiveApplication3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICoreApplication2), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class CoreApplication
  {
    [Overload("CreateNewViewWithViewSource")]
    [MethodImpl]
    public static extern CoreApplicationView CreateNewView(
      IFrameworkViewSource viewSource);

    [Overload("CreateNewViewFromMainView")]
    [MethodImpl]
    public static extern CoreApplicationView CreateNewView();

    public static extern event EventHandler<UnhandledErrorDetectedEventArgs> UnhandledErrorDetected;

    [MethodImpl]
    public static extern void IncrementApplicationUseCount();

    [MethodImpl]
    public static extern void DecrementApplicationUseCount();

    public static extern IVectorView<CoreApplicationView> Views { [MethodImpl] get; }

    [DefaultOverload]
    [Overload("CreateNewView")]
    [MethodImpl]
    public static extern CoreApplicationView CreateNewView(
      string runtimeType,
      string entryPoint);

    public static extern CoreApplicationView MainView { [MethodImpl] get; }

    [MethodImpl]
    public static extern void Exit();

    public static extern event EventHandler<object> Exiting;

    public static extern event EventHandler<BackgroundActivatedEventArgs> BackgroundActivated;

    public static extern event EventHandler<LeavingBackgroundEventArgs> LeavingBackground;

    public static extern event EventHandler<EnteredBackgroundEventArgs> EnteredBackground;

    [MethodImpl]
    public static extern void EnablePrelaunch(bool value);

    public static extern string Id { [MethodImpl] get; }

    public static extern event EventHandler<SuspendingEventArgs> Suspending;

    public static extern event EventHandler<object> Resuming;

    public static extern IPropertySet Properties { [MethodImpl] get; }

    [MethodImpl]
    public static extern CoreApplicationView GetCurrentView();

    [MethodImpl]
    public static extern void Run(IFrameworkViewSource viewSource);

    [MethodImpl]
    public static extern void RunWithActivationFactories(
      IGetActivationFactory activationFactoryCallback);
  }
}
