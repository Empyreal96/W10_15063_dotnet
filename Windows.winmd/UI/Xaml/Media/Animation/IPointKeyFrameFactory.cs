// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPointKeyFrameFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (PointKeyFrame))]
  [Guid(3407956959, 17002, 17298, 131, 85, 194, 174, 82, 133, 38, 35)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointKeyFrameFactory
  {
    PointKeyFrame CreateInstance(object outer, out object inner);
  }
}
