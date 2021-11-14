// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardAutomaticResponseApdu
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(1377119147, 50750, 17713, 168, 87, 215, 86, 217, 155, 152, 106)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [ExclusiveTo(typeof (SmartCardAutomaticResponseApdu))]
  internal interface ISmartCardAutomaticResponseApdu
  {
    IBuffer CommandApdu { get; set; }

    IBuffer CommandApduBitMask { get; set; }

    bool ShouldMatchLength { get; set; }

    IBuffer AppletId { get; set; }

    IBuffer ResponseApdu { get; set; }
  }
}
