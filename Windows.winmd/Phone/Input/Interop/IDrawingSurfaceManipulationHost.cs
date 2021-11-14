// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Input.Interop.IDrawingSurfaceManipulationHost
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.Phone.Input.Interop
{
  [ExclusiveTo(typeof (DrawingSurfaceManipulationHost))]
  [WebHostHidden]
  [Guid(3886867641, 50400, 18604, 188, 183, 66, 197, 212, 188, 137, 109)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IDrawingSurfaceManipulationHost
  {
    event TypedEventHandler<DrawingSurfaceManipulationHost, PointerEventArgs> PointerMoved;

    event TypedEventHandler<DrawingSurfaceManipulationHost, PointerEventArgs> PointerPressed;

    event TypedEventHandler<DrawingSurfaceManipulationHost, PointerEventArgs> PointerReleased;
  }
}
