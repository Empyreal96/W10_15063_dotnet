// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IObjectAnimationUsingKeyFrames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(860499346, 46922, 19556, 185, 166, 88, 188, 250, 49, 79, 34)]
  [ExclusiveTo(typeof (ObjectAnimationUsingKeyFrames))]
  internal interface IObjectAnimationUsingKeyFrames
  {
    ObjectKeyFrameCollection KeyFrames { get; }

    bool EnableDependentAnimation { get; set; }
  }
}
