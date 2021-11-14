// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.IPhoneCallFilterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [Guid(1893822925, 12736, 17252, 169, 95, 185, 72, 105, 152, 183, 118)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (PhoneCallFilter))]
  internal interface IPhoneCallFilterStatics
  {
    void EnableFiltering(bool enablePhoneCallFiltering);

    void SetCallBlockingPreferences(
      IIterable<string> phoneNumbersToBlock,
      uint desiredMinimumDigitsToMatch,
      TelephoneNumberCategories categoriesToBlock);

    PhoneCallFilterStatus Status { get; }

    event EventHandler<PhoneCallBlockedEventArgs> PhoneCallBlocked;

    event EventHandler<object> StatusChanged;
  }
}
