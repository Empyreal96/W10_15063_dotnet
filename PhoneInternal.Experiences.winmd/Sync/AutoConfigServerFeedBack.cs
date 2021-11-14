// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.AutoConfigServerFeedBack
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  [Flags]
  public enum AutoConfigServerFeedBack : uint
  {
    None = 0,
    UploadIncomingServerSetting = 1,
    UploadOutgoingServerSetting = 2,
  }
}
