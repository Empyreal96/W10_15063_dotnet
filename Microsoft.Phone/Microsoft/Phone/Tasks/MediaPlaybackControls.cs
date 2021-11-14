// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.MediaPlaybackControls
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Tasks
{
  [Flags]
  public enum MediaPlaybackControls
  {
    None = 0,
    Pause = 1,
    Stop = 2,
    FastForward = 4,
    Rewind = 8,
    Skip = 16, // 0x00000010
    All = Skip | Rewind | FastForward | Stop | Pause, // 0x0000001F
  }
}
