// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.PhoneCallFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPhoneCallFilterStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public static class PhoneCallFilter
  {
    [MethodImpl]
    public static extern void EnableFiltering(bool enablePhoneCallFiltering);

    [MethodImpl]
    public static extern void SetCallBlockingPreferences(
      IIterable<string> phoneNumbersToBlock,
      uint desiredMinimumDigitsToMatch,
      TelephoneNumberCategories categoriesToBlock);

    public static extern PhoneCallFilterStatus Status { [MethodImpl] get; }

    public static extern event EventHandler<PhoneCallBlockedEventArgs> PhoneCallBlocked;

    public static extern event EventHandler<object> StatusChanged;
  }
}
