// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICalendarIdentifiersStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(740447267, 8109, 16576, 147, 52, 168, 235, 144, 219, 4, 245)]
  [ExclusiveTo(typeof (CalendarIdentifiers))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICalendarIdentifiersStatics3
  {
    string ChineseLunar { get; }

    string JapaneseLunar { get; }

    string KoreanLunar { get; }

    string TaiwanLunar { get; }

    string VietnameseLunar { get; }
  }
}
