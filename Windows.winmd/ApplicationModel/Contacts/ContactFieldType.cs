// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactFieldType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactFieldType
  {
    Email,
    PhoneNumber,
    [Deprecated("Location  may be altered or unavailable for releases after Windows 8.1. Instead, use Address.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Location,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536), Deprecated("InstantMessage  may be altered or unavailable for releases after Windows 8.1. Instead, use ConnectedServiceAccount.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] InstantMessage,
    [Deprecated("Custom may be altered or unavailable for releases after Windows 8.1. Instead, use one of the specific types.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Custom,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ConnectedServiceAccount,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ImportantDate,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Address,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] SignificantOther,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Notes,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Website,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] JobInfo,
  }
}
