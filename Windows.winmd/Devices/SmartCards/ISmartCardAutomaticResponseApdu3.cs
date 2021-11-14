// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardAutomaticResponseApdu3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 196608)]
  [ExclusiveTo(typeof (SmartCardAutomaticResponseApdu))]
  [Guid(3208895092, 25974, 17298, 147, 103, 254, 59, 201, 226, 212, 150)]
  internal interface ISmartCardAutomaticResponseApdu3
  {
    bool AllowWhenCryptogramGeneratorNotPrepared { get; set; }
  }
}
