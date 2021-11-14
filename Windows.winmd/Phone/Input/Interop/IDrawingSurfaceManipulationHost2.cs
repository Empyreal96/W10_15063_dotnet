// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Input.Interop.IDrawingSurfaceManipulationHost2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.Phone.Input.Interop
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (DrawingSurfaceManipulationHost))]
  [WebHostHidden]
  [Guid(1402891097, 46343, 19301, 163, 246, 55, 112, 22, 5, 59, 9)]
  internal interface IDrawingSurfaceManipulationHost2
  {
    event TypedEventHandler<DrawingSurfaceManipulationHost, PointerEventArgs> PointerEntered;

    event TypedEventHandler<DrawingSurfaceManipulationHost, PointerEventArgs> PointerExited;
  }
}
