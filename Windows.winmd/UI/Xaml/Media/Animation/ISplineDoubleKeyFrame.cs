﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplineDoubleKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SplineDoubleKeyFrame))]
  [WebHostHidden]
  [Guid(14101816, 27435, 18499, 131, 142, 200, 177, 21, 238, 200, 1)]
  internal interface ISplineDoubleKeyFrame
  {
    KeySpline KeySpline { get; set; }
  }
}
