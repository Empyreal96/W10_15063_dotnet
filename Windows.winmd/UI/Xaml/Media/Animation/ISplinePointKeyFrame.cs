// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplinePointKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(253358854, 28726, 18767, 188, 60, 120, 13, 240, 204, 82, 74)]
  [ExclusiveTo(typeof (SplinePointKeyFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISplinePointKeyFrame
  {
    KeySpline KeySpline { get; set; }
  }
}
