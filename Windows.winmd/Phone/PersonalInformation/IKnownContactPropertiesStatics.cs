// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IKnownContactPropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (KnownContactProperties))]
  [Guid(3582012161, 11501, 20198, 177, 214, 9, 75, 248, 142, 240, 182)]
  internal interface IKnownContactPropertiesStatics
  {
    string DisplayName { get; }

    string FamilyName { get; }

    string GivenName { get; }

    string HonorificPrefix { get; }

    string HonorificSuffix { get; }

    string AdditionalName { get; }

    string Address { get; }

    string OtherAddress { get; }

    string Email { get; }

    string WorkAddress { get; }

    string WorkTelephone { get; }

    string JobTitle { get; }

    string Birthdate { get; }

    string Anniversary { get; }

    string Telephone { get; }

    string MobileTelephone { get; }

    string Url { get; }

    string Notes { get; }

    string WorkFax { get; }

    string Children { get; }

    string SignificantOther { get; }

    string CompanyName { get; }

    string CompanyTelephone { get; }

    string HomeFax { get; }

    string AlternateTelephone { get; }

    string Manager { get; }

    string Nickname { get; }

    string OfficeLocation { get; }

    string WorkEmail { get; }

    string YomiGivenName { get; }

    string YomiFamilyName { get; }

    string YomiCompanyName { get; }

    string OtherEmail { get; }

    string AlternateMobileTelephone { get; }

    string AlternateWorkTelephone { get; }
  }
}
