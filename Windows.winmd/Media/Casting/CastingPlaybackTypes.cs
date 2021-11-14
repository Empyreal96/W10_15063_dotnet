// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingPlaybackTypes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum CastingPlaybackTypes : uint
  {
    None = 0,
    Audio = 1,
    Video = 2,
    Picture = 4,
  }
}
