// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2042222066, 34718, 19337, 183, 152, 121, 228, 117, 152, 3, 12)]
  [WebHostHidden]
  public interface ICoreWindow
  {
    object AutomationHostProvider { get; }

    Rect Bounds { get; }

    IPropertySet CustomProperties { get; }

    CoreDispatcher Dispatcher { get; }

    CoreWindowFlowDirection FlowDirection { get; set; }

    bool IsInputEnabled { get; set; }

    CoreCursor PointerCursor { get; set; }

    Point PointerPosition { get; }

    bool Visible { get; }

    void Activate();

    void Close();

    CoreVirtualKeyStates GetAsyncKeyState(VirtualKey virtualKey);

    CoreVirtualKeyStates GetKeyState(VirtualKey virtualKey);

    void ReleasePointerCapture();

    void SetPointerCapture();

    event TypedEventHandler<CoreWindow, WindowActivatedEventArgs> Activated;

    event TypedEventHandler<CoreWindow, AutomationProviderRequestedEventArgs> AutomationProviderRequested;

    event TypedEventHandler<CoreWindow, CharacterReceivedEventArgs> CharacterReceived;

    event TypedEventHandler<CoreWindow, CoreWindowEventArgs> Closed;

    event TypedEventHandler<CoreWindow, InputEnabledEventArgs> InputEnabled;

    event TypedEventHandler<CoreWindow, KeyEventArgs> KeyDown;

    event TypedEventHandler<CoreWindow, KeyEventArgs> KeyUp;

    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerCaptureLost;

    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerEntered;

    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerExited;

    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerMoved;

    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerPressed;

    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerReleased;

    event TypedEventHandler<CoreWindow, TouchHitTestingEventArgs> TouchHitTesting;

    event TypedEventHandler<CoreWindow, PointerEventArgs> PointerWheelChanged;

    event TypedEventHandler<CoreWindow, WindowSizeChangedEventArgs> SizeChanged;

    event TypedEventHandler<CoreWindow, VisibilityChangedEventArgs> VisibilityChanged;
  }
}
