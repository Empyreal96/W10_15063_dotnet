﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSource2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSource))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(394855234, 26464, 19385, 165, 138, 247, 170, 152, 176, 140, 14)]
  internal interface IAdaptiveMediaSource2
  {
    AdaptiveMediaSourceAdvancedSettings AdvancedSettings { get; }
  }
}
