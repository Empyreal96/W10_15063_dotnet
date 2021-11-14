﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SplineColorKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (ISplineColorKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SplineColorKeyFrame : ColorKeyFrame, ISplineColorKeyFrame
  {
    [MethodImpl]
    public extern SplineColorKeyFrame();

    public extern KeySpline KeySpline { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty KeySplineProperty { [MethodImpl] get; }
  }
}
