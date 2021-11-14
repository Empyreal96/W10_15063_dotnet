// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Window
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IWindowStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Window : IWindow, IWindow2, IWindow3
  {
    public extern Rect Bounds { [MethodImpl] get; }

    public extern bool Visible { [MethodImpl] get; }

    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    public extern CoreWindow CoreWindow { [MethodImpl] get; }

    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    public extern event WindowActivatedEventHandler Activated;

    public extern event WindowClosedEventHandler Closed;

    public extern event WindowSizeChangedEventHandler SizeChanged;

    public extern event WindowVisibilityChangedEventHandler VisibilityChanged;

    [MethodImpl]
    public extern void Activate();

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public extern void SetTitleBar(UIElement value);

    public extern Compositor Compositor { [MethodImpl] get; }

    public static extern Window Current { [MethodImpl] get; }
  }
}
