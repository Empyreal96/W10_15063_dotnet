// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.PlaybackCapability
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Flags]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public enum PlaybackCapability : uint
  {
    None = 0,
    Play = 1,
    Pause = 2,
    Stop = 4,
    Record = 8,
    FastForward = 16, // 0x00000010
    Rewind = 32, // 0x00000020
    Next = 64, // 0x00000040
    Previous = 128, // 0x00000080
    ChannelUp = 256, // 0x00000100
    ChannelDown = 512, // 0x00000200
  }
}
