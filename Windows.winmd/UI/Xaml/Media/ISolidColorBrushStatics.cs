// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ISolidColorBrushStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [Guid(3785776890, 11043, 16826, 185, 186, 112, 148, 236, 142, 78, 159)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SolidColorBrush))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISolidColorBrushStatics
  {
    DependencyProperty ColorProperty { [IndependentlyAnimatable] get; }
  }
}
