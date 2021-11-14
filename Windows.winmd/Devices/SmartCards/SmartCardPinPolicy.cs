// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardPinPolicy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SmartCardPinPolicy : ISmartCardPinPolicy
  {
    [MethodImpl]
    public extern SmartCardPinPolicy();

    public extern uint MinLength { [MethodImpl] get; [MethodImpl] set; }

    public extern uint MaxLength { [MethodImpl] get; [MethodImpl] set; }

    public extern SmartCardPinCharacterPolicyOption UppercaseLetters { [MethodImpl] get; [MethodImpl] set; }

    public extern SmartCardPinCharacterPolicyOption LowercaseLetters { [MethodImpl] get; [MethodImpl] set; }

    public extern SmartCardPinCharacterPolicyOption Digits { [MethodImpl] get; [MethodImpl] set; }

    public extern SmartCardPinCharacterPolicyOption SpecialCharacters { [MethodImpl] get; [MethodImpl] set; }
  }
}
