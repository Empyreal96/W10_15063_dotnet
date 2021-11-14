// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.Contact
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
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  public sealed class Contact : IContact, IContact2, IContactName, IContact3
  {
    [MethodImpl]
    public extern Contact();

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<IContactField> Fields { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    public extern string Notes { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<ContactPhone> Phones { [MethodImpl] get; }

    public extern IVector<ContactEmail> Emails { [MethodImpl] get; }

    public extern IVector<ContactAddress> Addresses { [MethodImpl] get; }

    public extern IVector<ContactConnectedServiceAccount> ConnectedServiceAccounts { [MethodImpl] get; }

    public extern IVector<ContactDate> ImportantDates { [MethodImpl] get; }

    public extern IVector<string> DataSuppliers { [MethodImpl] get; }

    public extern IVector<ContactJobInfo> JobInfo { [MethodImpl] get; }

    public extern IVector<ContactSignificantOther> SignificantOthers { [MethodImpl] get; }

    public extern IVector<ContactWebsite> Websites { [MethodImpl] get; }

    public extern IPropertySet ProviderProperties { [MethodImpl] get; }

    public extern string FirstName { [MethodImpl] get; [MethodImpl] set; }

    public extern string LastName { [MethodImpl] get; [MethodImpl] set; }

    public extern string MiddleName { [MethodImpl] get; [MethodImpl] set; }

    public extern string YomiGivenName { [MethodImpl] get; [MethodImpl] set; }

    public extern string YomiFamilyName { [MethodImpl] get; [MethodImpl] set; }

    public extern string HonorificNameSuffix { [MethodImpl] get; [MethodImpl] set; }

    public extern string HonorificNamePrefix { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern string YomiDisplayName { [MethodImpl] get; }

    public extern string ContactListId { [MethodImpl] get; }

    public extern DateTime DisplayPictureUserUpdateTime { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsMe { [MethodImpl] get; }

    public extern string AggregateId { [MethodImpl] get; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    public extern string RingToneToken { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDisplayPictureManuallySet { [MethodImpl] get; }

    public extern IRandomAccessStreamReference LargeDisplayPicture { [MethodImpl] get; }

    public extern IRandomAccessStreamReference SmallDisplayPicture { [MethodImpl] get; }

    public extern IRandomAccessStreamReference SourceDisplayPicture { [MethodImpl] get; [MethodImpl] set; }

    public extern string TextToneToken { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsAggregate { [MethodImpl] get; }

    public extern string FullName { [MethodImpl] get; }

    public extern string DisplayNameOverride { [MethodImpl] get; [MethodImpl] set; }

    public extern string Nickname { [MethodImpl] get; [MethodImpl] set; }

    public extern string SortName { [MethodImpl] get; }
  }
}
