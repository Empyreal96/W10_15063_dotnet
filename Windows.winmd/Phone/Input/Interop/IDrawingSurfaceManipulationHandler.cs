// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Input.Interop.IDrawingSurfaceManipulationHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Input.Interop
{
  [WebHostHidden]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(387677943, 43375, 20023, 185, 54, 122, 11, 16, 243, 81, 99)]
  public interface IDrawingSurfaceManipulationHandler
  {
    void SetManipulationHost(DrawingSurfaceManipulationHost manipulationHost);
  }
}
