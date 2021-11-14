// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Input.IHardwareButtonsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Input
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (HardwareButtons))]
  [Guid(1498122112, 55910, 20440, 167, 118, 117, 6, 189, 12, 191, 167)]
  internal interface IHardwareButtonsStatics
  {
    event EventHandler<BackPressedEventArgs> BackPressed;
  }
}
