// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactSignificantOther2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2373702772, 16131, 17912, 186, 15, 196, 237, 55, 214, 66, 25)]
  [ExclusiveTo(typeof (ContactSignificantOther))]
  internal interface IContactSignificantOther2 : IContactSignificantOther
  {
    ContactRelationship Relationship { get; set; }
  }
}
