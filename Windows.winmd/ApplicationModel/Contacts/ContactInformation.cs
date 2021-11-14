// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactInformation : IContactInformation
  {
    public extern string Name { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> GetThumbnailAsync();

    public extern IVectorView<ContactField> Emails { [MethodImpl] get; }

    public extern IVectorView<ContactField> PhoneNumbers { [MethodImpl] get; }

    public extern IVectorView<ContactLocationField> Locations { [MethodImpl] get; }

    public extern IVectorView<ContactInstantMessageField> InstantMessages { [MethodImpl] get; }

    public extern IVectorView<ContactField> CustomFields { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<ContactField> QueryCustomFields(
      string customName);
  }
}
