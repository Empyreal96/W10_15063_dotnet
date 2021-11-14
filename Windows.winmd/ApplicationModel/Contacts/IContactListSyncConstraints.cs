// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactListSyncConstraints
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2997927681, 12386, 20014, 150, 157, 1, 141, 25, 135, 243, 20)]
  [ExclusiveTo(typeof (ContactListSyncConstraints))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IContactListSyncConstraints
  {
    bool CanSyncDescriptions { get; set; }

    IReference<int> MaxHomePhoneNumbers { get; set; }

    IReference<int> MaxMobilePhoneNumbers { get; set; }

    IReference<int> MaxWorkPhoneNumbers { get; set; }

    IReference<int> MaxOtherPhoneNumbers { get; set; }

    IReference<int> MaxPagerPhoneNumbers { get; set; }

    IReference<int> MaxBusinessFaxPhoneNumbers { get; set; }

    IReference<int> MaxHomeFaxPhoneNumbers { get; set; }

    IReference<int> MaxCompanyPhoneNumbers { get; set; }

    IReference<int> MaxAssistantPhoneNumbers { get; set; }

    IReference<int> MaxRadioPhoneNumbers { get; set; }

    IReference<int> MaxPersonalEmailAddresses { get; set; }

    IReference<int> MaxWorkEmailAddresses { get; set; }

    IReference<int> MaxOtherEmailAddresses { get; set; }

    IReference<int> MaxHomeAddresses { get; set; }

    IReference<int> MaxWorkAddresses { get; set; }

    IReference<int> MaxOtherAddresses { get; set; }

    IReference<int> MaxBirthdayDates { get; set; }

    IReference<int> MaxAnniversaryDates { get; set; }

    IReference<int> MaxOtherDates { get; set; }

    IReference<int> MaxOtherRelationships { get; set; }

    IReference<int> MaxSpouseRelationships { get; set; }

    IReference<int> MaxPartnerRelationships { get; set; }

    IReference<int> MaxSiblingRelationships { get; set; }

    IReference<int> MaxParentRelationships { get; set; }

    IReference<int> MaxChildRelationships { get; set; }

    IReference<int> MaxJobInfo { get; set; }

    IReference<int> MaxWebsites { get; set; }
  }
}
