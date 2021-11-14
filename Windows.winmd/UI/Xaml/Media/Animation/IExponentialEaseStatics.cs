// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IExponentialEaseStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ExponentialEase))]
  [WebHostHidden]
  [Guid(4085180387, 42849, 17234, 154, 214, 112, 121, 69, 103, 88, 26)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IExponentialEaseStatics
  {
    DependencyProperty ExponentProperty { get; }
  }
}
