// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarToggleButtonStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4267356054, 31017, 19873, 170, 103, 205, 223, 115, 163, 228, 181)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppBarToggleButton))]
  [WebHostHidden]
  internal interface IAppBarToggleButtonStatics
  {
    DependencyProperty LabelProperty { get; }

    DependencyProperty IconProperty { get; }

    DependencyProperty IsCompactProperty { get; }
  }
}
