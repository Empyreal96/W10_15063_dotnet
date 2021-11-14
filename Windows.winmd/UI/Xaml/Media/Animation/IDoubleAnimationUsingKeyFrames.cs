// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDoubleAnimationUsingKeyFrames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(1341022863, 49134, 20341, 131, 194, 169, 59, 57, 72, 132, 115)]
  [ExclusiveTo(typeof (DoubleAnimationUsingKeyFrames))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDoubleAnimationUsingKeyFrames
  {
    DoubleKeyFrameCollection KeyFrames { get; }

    bool EnableDependentAnimation { get; set; }
  }
}
