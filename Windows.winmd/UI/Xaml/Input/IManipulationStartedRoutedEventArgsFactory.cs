// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationStartedRoutedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(2227296935, 29298, 17507, 182, 195, 164, 11, 155, 161, 81, 252)]
  [ExclusiveTo(typeof (ManipulationStartedRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IManipulationStartedRoutedEventArgsFactory
  {
    ManipulationStartedRoutedEventArgs CreateInstance(
      object outer,
      out object inner);
  }
}
