// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactWebsite2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(4169066782, 22087, 16488, 187, 94, 75, 111, 67, 124, 227, 8)]
  [ExclusiveTo(typeof (ContactWebsite))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactWebsite2 : IContactWebsite
  {
    string RawValue { get; set; }
  }
}
