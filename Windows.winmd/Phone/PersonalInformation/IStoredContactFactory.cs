// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IStoredContactFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (StoredContact))]
  [Guid(1240328481, 49701, 20441, 137, 197, 206, 204, 44, 138, 75, 121)]
  internal interface IStoredContactFactory
  {
    StoredContact CreateStoredContact(ContactStore store);

    StoredContact CreateStoredContactFromInformation(
      ContactStore store,
      ContactInformation contact);
  }
}
