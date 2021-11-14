// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Input.HardwareButtons
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Input
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHardwareButtonsStatics2), 65536, "Windows.Phone.PhoneContract")]
  [Static(typeof (IHardwareButtonsStatics), 65536, "Windows.Phone.PhoneContract")]
  public static class HardwareButtons
  {
    public static extern event EventHandler<BackPressedEventArgs> BackPressed;

    public static extern event EventHandler<CameraEventArgs> CameraHalfPressed;

    public static extern event EventHandler<CameraEventArgs> CameraPressed;

    public static extern event EventHandler<CameraEventArgs> CameraReleased;
  }
}
