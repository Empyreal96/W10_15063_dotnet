// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(660518612, 27182, 17016, 169, 20, 228, 96, 213, 240, 136, 246)]
  [ExclusiveTo(typeof (ContactInformation))]
  internal interface IContactInformation
  {
    string Name { get; }

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamWithContentType> GetThumbnailAsync();

    IVectorView<ContactField> Emails { get; }

    IVectorView<ContactField> PhoneNumbers { get; }

    IVectorView<ContactLocationField> Locations { get; }

    IVectorView<ContactInstantMessageField> InstantMessages { get; }

    IVectorView<ContactField> CustomFields { get; }

    IVectorView<ContactField> QueryCustomFields(string customName);
  }
}
