// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Input.IHardwareButtonsStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Input
{
  [ExclusiveTo(typeof (HardwareButtons))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(969327220, 39231, 16605, 133, 76, 131, 26, 137, 52, 185, 46)]
  internal interface IHardwareButtonsStatics2
  {
    event EventHandler<CameraEventArgs> CameraHalfPressed;

    event EventHandler<CameraEventArgs> CameraPressed;

    event EventHandler<CameraEventArgs> CameraReleased;
  }
}
