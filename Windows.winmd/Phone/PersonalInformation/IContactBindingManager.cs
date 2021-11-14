// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactBindingManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(3668411676, 46665, 15673, 147, 126, 156, 88, 62, 122, 97, 207)]
  [ExclusiveTo(typeof (ContactBindingManager))]
  internal interface IContactBindingManager
  {
    ContactBinding CreateContactBinding(string RemoteId);

    IAsyncOperation<ContactBinding> CreateOrOpenMeContactBindingAsync(
      string RemoteId);

    IAsyncOperation<IVectorView<ContactBinding>> GetContactBindingsAsync();

    IAsyncOperation<ContactBinding> GetContactBindingByRemoteIdAsync(
      string RemoteId);

    IAsyncOperation<ContactBinding> GetContactBindingFromStoredContactAsync(
      string ContactId);

    IAsyncAction SaveContactBindingAsync(ContactBinding binding);

    IAsyncAction DeleteContactBindingAsync(ContactBinding binding);

    IAsyncAction DeleteAllContactBindingsAsync();

    IAsyncAction CreateContactBindingTileAsync(
      string LocalContext,
      ContactBinding binding);
  }
}
