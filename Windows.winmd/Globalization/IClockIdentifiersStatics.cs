// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.IClockIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (ClockIdentifiers))]
  [Guid(1379403195, 4844, 20355, 188, 49, 177, 180, 55, 107, 8, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IClockIdentifiersStatics
  {
    string TwelveHour { get; }

    string TwentyFourHour { get; }
  }
}
