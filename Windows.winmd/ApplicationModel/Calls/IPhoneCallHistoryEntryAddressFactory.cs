// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryEntryAddressFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4212108730, 51184, 19382, 159, 107, 186, 93, 115, 32, 154, 202)]
  [ExclusiveTo(typeof (PhoneCallHistoryEntryAddress))]
  internal interface IPhoneCallHistoryEntryAddressFactory
  {
    PhoneCallHistoryEntryAddress Create(
      string rawAddress,
      PhoneCallHistoryEntryRawAddressKind rawAddressKind);
  }
}
