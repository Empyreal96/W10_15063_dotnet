// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardAutomaticResponseApdu2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [Guid(1152301844, 21917, 17713, 78, 81, 137, 219, 111, 168, 165, 122)]
  [ExclusiveTo(typeof (SmartCardAutomaticResponseApdu))]
  internal interface ISmartCardAutomaticResponseApdu2
  {
    IReference<uint> InputState { get; set; }

    IReference<uint> OutputState { get; set; }
  }
}
