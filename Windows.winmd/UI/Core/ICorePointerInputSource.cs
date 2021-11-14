// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICorePointerInputSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3153181464, 58490, 18667, 136, 7, 248, 248, 211, 234, 69, 81)]
  public interface ICorePointerInputSource
  {
    void ReleasePointerCapture();

    void SetPointerCapture();

    bool HasCapture { get; }

    Point PointerPosition { get; }

    CoreCursor PointerCursor { get; set; }

    event TypedEventHandler<object, PointerEventArgs> PointerCaptureLost;

    event TypedEventHandler<object, PointerEventArgs> PointerEntered;

    event TypedEventHandler<object, PointerEventArgs> PointerExited;

    event TypedEventHandler<object, PointerEventArgs> PointerMoved;

    event TypedEventHandler<object, PointerEventArgs> PointerPressed;

    event TypedEventHandler<object, PointerEventArgs> PointerReleased;

    event TypedEventHandler<object, PointerEventArgs> PointerWheelChanged;
  }
}
