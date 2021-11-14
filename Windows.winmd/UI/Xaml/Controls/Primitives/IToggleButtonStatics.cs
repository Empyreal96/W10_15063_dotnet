// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IToggleButtonStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (ToggleButton))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2938022674, 296, 20327, 156, 90, 130, 50, 12, 68, 93, 25)]
  [WebHostHidden]
  internal interface IToggleButtonStatics
  {
    DependencyProperty IsCheckedProperty { get; }

    DependencyProperty IsThreeStateProperty { get; }
  }
}
