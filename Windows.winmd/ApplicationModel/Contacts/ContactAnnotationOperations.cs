// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactAnnotationOperations
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactAnnotationOperations : uint
  {
    None = 0,
    ContactProfile = 1,
    Message = 2,
    AudioCall = 4,
    VideoCall = 8,
    SocialFeeds = 16, // 0x00000010
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Share = 32, // 0x00000020
  }
}
