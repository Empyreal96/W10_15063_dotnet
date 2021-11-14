// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Input.IBackPressedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Input
{
  [ExclusiveTo(typeof (BackPressedEventArgs))]
  [Guid(4143273471, 25836, 17058, 185, 59, 47, 188, 12, 54, 161, 33)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IBackPressedEventArgs
  {
    bool Handled { get; set; }
  }
}
