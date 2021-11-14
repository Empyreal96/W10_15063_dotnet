// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Application
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Composable(typeof (IApplicationFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IApplicationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class Application : 
    IApplication,
    IApplicationOverrides,
    IApplication2,
    IApplicationOverrides2,
    IApplication3
  {
    [MethodImpl]
    public extern Application();

    public extern ResourceDictionary Resources { [MethodImpl] get; [MethodImpl] set; }

    public extern DebugSettings DebugSettings { [MethodImpl] get; }

    public extern ApplicationTheme RequestedTheme { [MethodImpl] get; [MethodImpl] set; }

    public extern event UnhandledExceptionEventHandler UnhandledException;

    public extern event SuspendingEventHandler Suspending;

    public extern event EventHandler<object> Resuming;

    [MethodImpl]
    public extern void Exit();

    [MethodImpl]
    extern void IApplicationOverrides.OnActivated(IActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnLaunched(LaunchActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnFileActivated(
      FileActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnSearchActivated(
      SearchActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnShareTargetActivated(
      ShareTargetActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnFileOpenPickerActivated(
      FileOpenPickerActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnFileSavePickerActivated(
      FileSavePickerActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnCachedFileUpdaterActivated(
      CachedFileUpdaterActivatedEventArgs args);

    [MethodImpl]
    extern void IApplicationOverrides.OnWindowCreated(
      WindowCreatedEventArgs args);

    public extern FocusVisualKind FocusVisualKind { [MethodImpl] get; [MethodImpl] set; }

    public extern ApplicationRequiresPointerMode RequiresPointerMode { [MethodImpl] get; [MethodImpl] set; }

    public extern event LeavingBackgroundEventHandler LeavingBackground;

    public extern event EnteredBackgroundEventHandler EnteredBackground;

    [MethodImpl]
    extern void IApplicationOverrides2.OnBackgroundActivated(
      BackgroundActivatedEventArgs args);

    public extern ApplicationHighContrastAdjustment HighContrastAdjustment { [MethodImpl] get; [MethodImpl] set; }

    public static extern Application Current { [MethodImpl] get; }

    [MethodImpl]
    public static extern void Start(ApplicationInitializationCallback callback);

    [Overload("LoadComponent")]
    [MethodImpl]
    public static extern void LoadComponent(object component, Uri resourceLocator);

    [Overload("LoadComponentWithResourceLocation")]
    [MethodImpl]
    public static extern void LoadComponent(
      object component,
      Uri resourceLocator,
      ComponentResourceLocation componentResourceLocation);
  }
}
