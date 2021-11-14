// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreComponentInputSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [Muse(Version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class CoreComponentInputSource : 
    ICoreInputSourceBase,
    ICorePointerInputSource,
    ICoreKeyboardInputSource,
    ICoreComponentFocusable,
    ICoreTouchHitTesting,
    ICoreClosestInteractiveBoundsRequested,
    ICoreKeyboardInputSource2
  {
    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    public extern bool IsInputEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<object, InputEnabledEventArgs> InputEnabled;

    [MethodImpl]
    public extern void ReleasePointerCapture();

    [MethodImpl]
    public extern void SetPointerCapture();

    public extern bool HasCapture { [MethodImpl] get; }

    public extern Point PointerPosition { [MethodImpl] get; }

    public extern CoreCursor PointerCursor { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<object, PointerEventArgs> PointerCaptureLost;

    public extern event TypedEventHandler<object, PointerEventArgs> PointerEntered;

    public extern event TypedEventHandler<object, PointerEventArgs> PointerExited;

    public extern event TypedEventHandler<object, PointerEventArgs> PointerMoved;

    public extern event TypedEventHandler<object, PointerEventArgs> PointerPressed;

    public extern event TypedEventHandler<object, PointerEventArgs> PointerReleased;

    public extern event TypedEventHandler<object, PointerEventArgs> PointerWheelChanged;

    [MethodImpl]
    public extern CoreVirtualKeyStates GetCurrentKeyState(VirtualKey virtualKey);

    public extern event TypedEventHandler<object, CharacterReceivedEventArgs> CharacterReceived;

    public extern event TypedEventHandler<object, KeyEventArgs> KeyDown;

    public extern event TypedEventHandler<object, KeyEventArgs> KeyUp;

    public extern bool HasFocus { [MethodImpl] get; }

    public extern event TypedEventHandler<object, CoreWindowEventArgs> GotFocus;

    public extern event TypedEventHandler<object, CoreWindowEventArgs> LostFocus;

    public extern event TypedEventHandler<object, TouchHitTestingEventArgs> TouchHitTesting;

    public extern event TypedEventHandler<CoreComponentInputSource, ClosestInteractiveBoundsRequestedEventArgs> ClosestInteractiveBoundsRequested;

    [MethodImpl]
    public extern string GetCurrentKeyEventDeviceId();
  }
}
