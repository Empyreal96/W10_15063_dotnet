// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IStoredContact
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (StoredContact))]
  [Guid(2960177073, 9789, 20081, 171, 231, 89, 29, 36, 102, 87, 14)]
  internal interface IStoredContact : IContactInformation
  {
    ContactStore Store { get; }

    string Id { get; }

    string RemoteId { get; set; }

    [return: HasVariant]
    IAsyncOperation<IMap<string, object>> GetExtendedPropertiesAsync();

    IAsyncAction SaveAsync();

    IAsyncAction ReplaceExistingContactAsync(string id);
  }
}
