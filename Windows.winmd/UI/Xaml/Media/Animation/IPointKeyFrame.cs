// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPointKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (PointKeyFrame))]
  [WebHostHidden]
  [Guid(4241001729, 32642, 19886, 128, 38, 123, 126, 8, 104, 120, 179)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointKeyFrame
  {
    Point Value { get; set; }

    KeyTime KeyTime { get; set; }
  }
}
