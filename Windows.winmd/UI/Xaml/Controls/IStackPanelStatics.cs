// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IStackPanelStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StackPanel))]
  [Guid(4040215955, 19900, 18599, 153, 20, 149, 73, 36, 101, 119, 113)]
  [WebHostHidden]
  internal interface IStackPanelStatics
  {
    DependencyProperty AreScrollSnapPointsRegularProperty { get; }

    DependencyProperty OrientationProperty { get; }
  }
}
