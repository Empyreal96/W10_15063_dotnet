// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContact3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(1210064487, 57486, 17060, 181, 97, 65, 208, 140, 169, 87, 93)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Contact))]
  internal interface IContact3 : IContact2, IContact
  {
    string ContactListId { get; }

    DateTime DisplayPictureUserUpdateTime { get; set; }

    bool IsMe { get; }

    string AggregateId { get; }

    string RemoteId { get; set; }

    string RingToneToken { get; set; }

    bool IsDisplayPictureManuallySet { get; }

    IRandomAccessStreamReference LargeDisplayPicture { get; }

    IRandomAccessStreamReference SmallDisplayPicture { get; }

    IRandomAccessStreamReference SourceDisplayPicture { get; set; }

    string TextToneToken { get; set; }

    bool IsAggregate { get; }

    string FullName { get; }

    string DisplayNameOverride { get; set; }

    string Nickname { get; set; }

    string SortName { get; }
  }
}
