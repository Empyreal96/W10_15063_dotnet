// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.KnownContactProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IKnownContactPropertiesStatics), 65536, "Windows.Phone.PhoneContract")]
  public static class KnownContactProperties
  {
    public static extern string DisplayName { [MethodImpl] get; }

    public static extern string FamilyName { [MethodImpl] get; }

    public static extern string GivenName { [MethodImpl] get; }

    public static extern string HonorificPrefix { [MethodImpl] get; }

    public static extern string HonorificSuffix { [MethodImpl] get; }

    public static extern string AdditionalName { [MethodImpl] get; }

    public static extern string Address { [MethodImpl] get; }

    public static extern string OtherAddress { [MethodImpl] get; }

    public static extern string Email { [MethodImpl] get; }

    public static extern string WorkAddress { [MethodImpl] get; }

    public static extern string WorkTelephone { [MethodImpl] get; }

    public static extern string JobTitle { [MethodImpl] get; }

    public static extern string Birthdate { [MethodImpl] get; }

    public static extern string Anniversary { [MethodImpl] get; }

    public static extern string Telephone { [MethodImpl] get; }

    public static extern string MobileTelephone { [MethodImpl] get; }

    public static extern string Url { [MethodImpl] get; }

    public static extern string Notes { [MethodImpl] get; }

    public static extern string WorkFax { [MethodImpl] get; }

    public static extern string Children { [MethodImpl] get; }

    public static extern string SignificantOther { [MethodImpl] get; }

    public static extern string CompanyName { [MethodImpl] get; }

    public static extern string CompanyTelephone { [MethodImpl] get; }

    public static extern string HomeFax { [MethodImpl] get; }

    public static extern string AlternateTelephone { [MethodImpl] get; }

    public static extern string Manager { [MethodImpl] get; }

    public static extern string Nickname { [MethodImpl] get; }

    public static extern string OfficeLocation { [MethodImpl] get; }

    public static extern string WorkEmail { [MethodImpl] get; }

    public static extern string YomiGivenName { [MethodImpl] get; }

    public static extern string YomiFamilyName { [MethodImpl] get; }

    public static extern string YomiCompanyName { [MethodImpl] get; }

    public static extern string OtherEmail { [MethodImpl] get; }

    public static extern string AlternateMobileTelephone { [MethodImpl] get; }

    public static extern string AlternateWorkTelephone { [MethodImpl] get; }
  }
}
