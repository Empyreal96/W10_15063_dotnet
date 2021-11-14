// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardPinPolicy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCardPinPolicy))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(406643076, 19894, 18497, 172, 158, 42, 193, 243, 155, 115, 4)]
  internal interface ISmartCardPinPolicy
  {
    uint MinLength { get; set; }

    uint MaxLength { get; set; }

    SmartCardPinCharacterPolicyOption UppercaseLetters { get; set; }

    SmartCardPinCharacterPolicyOption LowercaseLetters { get; set; }

    SmartCardPinCharacterPolicyOption Digits { get; set; }

    SmartCardPinCharacterPolicyOption SpecialCharacters { get; set; }
  }
}
