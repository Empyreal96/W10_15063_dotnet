// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationStartingRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(416691895, 21412, 19477, 164, 152, 243, 169, 202, 33, 42, 66)]
  [ExclusiveTo(typeof (ManipulationStartingRoutedEventArgs))]
  [WebHostHidden]
  internal interface IManipulationStartingRoutedEventArgs
  {
    ManipulationModes Mode { get; set; }

    UIElement Container { get; set; }

    ManipulationPivot Pivot { get; set; }

    bool Handled { get; set; }
  }
}
