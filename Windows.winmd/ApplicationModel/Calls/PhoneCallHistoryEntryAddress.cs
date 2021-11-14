// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryEntryAddress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Activatable(typeof (IPhoneCallHistoryEntryAddressFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PhoneCallHistoryEntryAddress : IPhoneCallHistoryEntryAddress
  {
    [MethodImpl]
    public extern PhoneCallHistoryEntryAddress(
      string rawAddress,
      PhoneCallHistoryEntryRawAddressKind rawAddressKind);

    [MethodImpl]
    public extern PhoneCallHistoryEntryAddress();

    public extern string ContactId { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern string RawAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern PhoneCallHistoryEntryRawAddressKind RawAddressKind { [MethodImpl] get; [MethodImpl] set; }
  }
}
