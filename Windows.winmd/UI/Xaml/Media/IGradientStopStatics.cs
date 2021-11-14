// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGradientStopStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(1613393269, 24979, 20453, 142, 130, 199, 198, 246, 254, 186, 253)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GradientStop))]
  internal interface IGradientStopStatics
  {
    DependencyProperty ColorProperty { get; }

    DependencyProperty OffsetProperty { get; }
  }
}
