// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorAnimationUsingKeyFrames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4123534912, 5059, 17066, 154, 226, 126, 107, 81, 201, 47, 149)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ColorAnimationUsingKeyFrames))]
  internal interface IColorAnimationUsingKeyFrames
  {
    ColorKeyFrameCollection KeyFrames { get; }

    bool EnableDependentAnimation { get; set; }
  }
}
