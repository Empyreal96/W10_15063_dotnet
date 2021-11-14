// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreWindow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICoreWindowStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Muse(Version = 100794368)]
  public sealed class CoreWindow : 
    ICoreWindow,
    ICoreWindow2,
    ICorePointerRedirector,
    ICoreWindow3,
    ICoreWindow4
  {
    public extern object AutomationHostProvider { [MethodImpl] get; }

    public extern Rect Bounds { [MethodImpl] get; }

    public extern IPropertySet CustomProperties { [MethodImpl] get; }

    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    public extern CoreWindowFlowDirection FlowDirection { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsInputEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern CoreCursor PointerCursor { [MethodImpl] get; [MethodImpl] set; }

    public extern Point PointerPosition { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Visible { [MethodImpl] get; }

    [MethodImpl]
    public extern void Activate();

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public extern CoreVirtualKeyStates GetAsyncKeyState(VirtualKey virtualKey);

    [MethodImpl]
    public extern CoreVirtualKeyStates GetKeyState(VirtualKey virtualKey);

    [MethodImpl]
    public extern void ReleasePointerCapture();

    [MethodImpl]
    public extern void SetPointerCapture();

    public extern event TypedEventHandler<CoreWindow, WindowActivatedEventArgs> Activated;

    public extern event TypedEventHandler<CoreWindow, AutomationProviderRequestedEventArgs> AutomationProviderRequested;

    public extern event TypedEventHandler<CoreWindow, CharacterReceivedEventArgs> CharacterReceived;

    public extern event TypedEventHandler<CoreWindow, CoreWindowEventArgs> Closed;

    public extern event TypedEventHandler<CoreWindow, InputEnabledEventArgs> InputEnabled;

    public extern event TypedEventHandler<CoreWindow, KeyEventArgs> KeyDown;

    public extern event TypedEventHandler<CoreWindow, KeyEventArgs> KeyUp;

    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerCaptureLost;

    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerEntered;

    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerExited;

    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerMoved;

    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerPressed;

    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerReleased;

    public extern event TypedEventHandler<CoreWindow, TouchHitTestingEventArgs> TouchHitTesting;

    public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerWheelChanged;

    public extern event TypedEventHandler<CoreWindow, WindowSizeChangedEventArgs> SizeChanged;

    public extern event TypedEventHandler<CoreWindow, VisibilityChangedEventArgs> VisibilityChanged;

    public extern event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedAway;

    public extern event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedTo;

    public extern event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedReleased;

    public extern event TypedEventHandler<CoreWindow, ClosestInteractiveBoundsRequestedEventArgs> ClosestInteractiveBoundsRequested;

    [MethodImpl]
    public extern string GetCurrentKeyEventDeviceId();

    public extern event TypedEventHandler<CoreWindow, object> ResizeStarted;

    public extern event TypedEventHandler<CoreWindow, object> ResizeCompleted;

    [MethodImpl]
    public static extern CoreWindow GetForCurrentThread();
  }
}
