// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICalendarIdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (CalendarIdentifiers))]
  [Guid(2154119016, 11442, 19487, 181, 144, 240, 245, 43, 244, 253, 26)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICalendarIdentifiersStatics
  {
    string Gregorian { get; }

    string Hebrew { get; }

    string Hijri { get; }

    string Japanese { get; }

    string Julian { get; }

    string Korean { get; }

    string Taiwan { get; }

    string Thai { get; }

    string UmAlQura { get; }
  }
}
