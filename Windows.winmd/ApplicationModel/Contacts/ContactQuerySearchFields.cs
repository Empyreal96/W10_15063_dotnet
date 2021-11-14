// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactQuerySearchFields
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum ContactQuerySearchFields : uint
  {
    None = 0,
    Name = 1,
    Email = 2,
    Phone = 4,
    All = 4294967295, // 0xFFFFFFFF
  }
}
