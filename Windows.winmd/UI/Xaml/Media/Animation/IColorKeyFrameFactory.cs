// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorKeyFrameFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(1989925002, 40187, 19069, 150, 196, 161, 231, 222, 111, 219, 75)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ColorKeyFrame))]
  internal interface IColorKeyFrameFactory
  {
    ColorKeyFrame CreateInstance(object outer, out object inner);
  }
}
