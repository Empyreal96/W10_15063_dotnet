// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.OnlinePhotos.UploadStatusDetails
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.OnlinePhotos
{
  [Version(100859904)]
  public enum UploadStatusDetails
  {
    NotAvailable = 0,
    Waiting = 1,
    WaitingForNextSchedule = 2,
    WaitingForWifi = 3,
    WaitingForConnectivity = 4,
    WaitingForSDCard = 5,
    WaitingForLowBattery = 6,
    Uploading = 7,
    Failed = 9,
    Finished = 10, // 0x0000000A
    Transcoding = 11, // 0x0000000B
    Resizing = 12, // 0x0000000C
  }
}
