// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILinearGradientBrushStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(2063000836, 11715, 16611, 190, 11, 179, 20, 193, 60, 185, 145)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (LinearGradientBrush))]
  internal interface ILinearGradientBrushStatics
  {
    DependencyProperty StartPointProperty { get; }

    DependencyProperty EndPointProperty { get; }
  }
}
