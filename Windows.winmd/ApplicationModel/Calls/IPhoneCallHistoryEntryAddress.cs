// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryEntryAddress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Guid(821123546, 14677, 16450, 132, 230, 102, 238, 191, 130, 230, 127)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhoneCallHistoryEntryAddress))]
  internal interface IPhoneCallHistoryEntryAddress
  {
    string ContactId { get; set; }

    string DisplayName { get; set; }

    string RawAddress { get; set; }

    PhoneCallHistoryEntryRawAddressKind RawAddressKind { get; set; }
  }
}
