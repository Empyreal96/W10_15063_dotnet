﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPointAnimationUsingKeyFrames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (PointAnimationUsingKeyFrames))]
  [Guid(2610188146, 17514, 16848, 161, 41, 65, 166, 32, 244, 89, 93)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointAnimationUsingKeyFrames
  {
    PointKeyFrameCollection KeyFrames { get; }

    bool EnableDependentAnimation { get; set; }
  }
}
