﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaTimelineControllerState
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum MediaTimelineControllerState
  {
    Paused,
    Running,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Stalled,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Error,
  }
}
