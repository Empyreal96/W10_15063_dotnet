﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.RepositionThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Static(typeof (IRepositionThemeTransitionStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class RepositionThemeTransition : 
    Transition,
    IRepositionThemeTransition,
    IRepositionThemeTransition2
  {
    [MethodImpl]
    public extern RepositionThemeTransition();

    public extern bool IsStaggeringEnabled { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IsStaggeringEnabledProperty { [MethodImpl] get; }
  }
}
