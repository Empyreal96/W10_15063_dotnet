﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DoubleAnimationUsingKeyFrames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media.Animation
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDoubleAnimationUsingKeyFramesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "KeyFrames")]
  [WebHostHidden]
  public sealed class DoubleAnimationUsingKeyFrames : Timeline, IDoubleAnimationUsingKeyFrames
  {
    [MethodImpl]
    public extern DoubleAnimationUsingKeyFrames();

    public extern DoubleKeyFrameCollection KeyFrames { [MethodImpl] get; }

    public extern bool EnableDependentAnimation { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty EnableDependentAnimationProperty { [MethodImpl] get; }
  }
}
