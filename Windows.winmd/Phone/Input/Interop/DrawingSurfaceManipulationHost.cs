// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Input.Interop.DrawingSurfaceManipulationHost
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.Phone.Input.Interop
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class DrawingSurfaceManipulationHost : 
    IDrawingSurfaceManipulationHost,
    IDrawingSurfaceManipulationHost2
  {
    public extern event TypedEventHandler<DrawingSurfaceManipulationHost, PointerEventArgs> PointerMoved;

    public extern event TypedEventHandler<DrawingSurfaceManipulationHost, PointerEventArgs> PointerPressed;

    public extern event TypedEventHandler<DrawingSurfaceManipulationHost, PointerEventArgs> PointerReleased;

    public extern event TypedEventHandler<DrawingSurfaceManipulationHost, PointerEventArgs> PointerEntered;

    public extern event TypedEventHandler<DrawingSurfaceManipulationHost, PointerEventArgs> PointerExited;
  }
}
