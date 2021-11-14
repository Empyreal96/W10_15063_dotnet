// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.NotificationTypeFlags
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Flags]
  [Version(100859904)]
  public enum NotificationTypeFlags : uint
  {
    None = 0,
    Audio = 1,
    Album = 2,
    Artist = 4,
    Genre = 8,
    Playlist = 16, // 0x00000010
  }
}
