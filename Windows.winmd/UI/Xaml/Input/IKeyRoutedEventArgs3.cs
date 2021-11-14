// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IKeyRoutedEventArgs3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (KeyRoutedEventArgs))]
  [Guid(662304180, 51777, 16667, 168, 239, 244, 252, 120, 231, 128, 87)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IKeyRoutedEventArgs3
  {
    string DeviceId { get; }
  }
}
