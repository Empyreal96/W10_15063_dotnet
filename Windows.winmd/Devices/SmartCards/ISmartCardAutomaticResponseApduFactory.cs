// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardAutomaticResponseApduFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCardAutomaticResponseApdu))]
  [Guid(3917390586, 53292, 19541, 176, 42, 140, 255, 127, 169, 240, 91)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  internal interface ISmartCardAutomaticResponseApduFactory
  {
    SmartCardAutomaticResponseApdu Create(
      IBuffer commandApdu,
      IBuffer responseApdu);
  }
}
