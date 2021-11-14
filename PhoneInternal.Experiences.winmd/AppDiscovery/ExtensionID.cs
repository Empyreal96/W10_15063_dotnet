// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.AppDiscovery.ExtensionID
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.AppDiscovery
{
  [Version(100859904)]
  [Flags]
  public enum ExtensionID : uint
  {
    None = 0,
    People_Connect = 1,
    People_Feeds = 2,
    People_Dashboard = 4,
    Me_CheckIn = 8,
    Me_Post = 16, // 0x00000010
    People_Post = 32, // 0x00000020
    Photos = 64, // 0x00000040
    Photos_Rooms = 128, // 0x00000080
    VoIP_DirectlyInitiateVideoCall = 256, // 0x00000100
    People_Connect_Manual = 512, // 0x00000200
    VoIP_DirectlyInitiateCallToPhoneNumber = 1024, // 0x00000400
    People_Profile = 2048, // 0x00000800
    People_Profile_Mobile = 4096, // 0x00001000
    All = People_Profile_Mobile | People_Profile | VoIP_DirectlyInitiateCallToPhoneNumber | People_Connect_Manual | VoIP_DirectlyInitiateVideoCall | Photos_Rooms | Photos | People_Post | Me_Post | Me_CheckIn | People_Dashboard | People_Feeds | People_Connect, // 0x00001FFF
  }
}
