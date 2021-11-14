// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IAggregateContactManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AggregateContactManager))]
  [Guid(58316253, 56154, 20435, 181, 78, 77, 241, 121, 23, 162, 18)]
  internal interface IAggregateContactManager
  {
    IAsyncOperation<IVectorView<Contact>> FindRawContactsAsync(
      Contact contact);

    IAsyncOperation<Contact> TryLinkContactsAsync(
      Contact primaryContact,
      Contact secondaryContact);

    IAsyncAction UnlinkRawContactAsync(Contact contact);

    IAsyncOperation<bool> TrySetPreferredSourceForPictureAsync(
      Contact aggregateContact,
      Contact rawContact);
  }
}
