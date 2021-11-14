// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDoubleKeyFrameStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(843465136, 32055, 17018, 173, 235, 67, 243, 139, 182, 26, 77)]
  [ExclusiveTo(typeof (DoubleKeyFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDoubleKeyFrameStatics
  {
    DependencyProperty ValueProperty { get; }

    DependencyProperty KeyTimeProperty { get; }
  }
}
