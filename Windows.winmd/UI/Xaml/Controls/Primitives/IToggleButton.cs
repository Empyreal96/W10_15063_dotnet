// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IToggleButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(1486387195, 4039, 16438, 157, 139, 18, 125, 250, 117, 193, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToggleButton))]
  [WebHostHidden]
  internal interface IToggleButton
  {
    IReference<bool> IsChecked { get; set; }

    bool IsThreeState { get; set; }

    event RoutedEventHandler Checked;

    event RoutedEventHandler Unchecked;

    event RoutedEventHandler Indeterminate;
  }
}
