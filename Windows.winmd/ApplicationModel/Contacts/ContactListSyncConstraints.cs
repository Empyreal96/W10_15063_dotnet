// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactListSyncConstraints
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class ContactListSyncConstraints : IContactListSyncConstraints
  {
    public extern bool CanSyncDescriptions { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxHomePhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxMobilePhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxWorkPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxOtherPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxPagerPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxBusinessFaxPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxHomeFaxPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxCompanyPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxAssistantPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxRadioPhoneNumbers { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxPersonalEmailAddresses { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxWorkEmailAddresses { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxOtherEmailAddresses { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxHomeAddresses { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxWorkAddresses { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxOtherAddresses { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxBirthdayDates { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxAnniversaryDates { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxOtherDates { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxOtherRelationships { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxSpouseRelationships { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxPartnerRelationships { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxSiblingRelationships { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxParentRelationships { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxChildRelationships { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxJobInfo { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> MaxWebsites { [MethodImpl] get; [MethodImpl] set; }
  }
}
