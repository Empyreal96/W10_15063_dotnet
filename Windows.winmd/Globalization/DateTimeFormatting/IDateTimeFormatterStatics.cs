// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.IDateTimeFormatterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  [Guid(3217942464, 57164, 18990, 144, 18, 244, 125, 175, 63, 18, 18)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DateTimeFormatter))]
  internal interface IDateTimeFormatterStatics
  {
    DateTimeFormatter LongDate { get; }

    DateTimeFormatter LongTime { get; }

    DateTimeFormatter ShortDate { get; }

    DateTimeFormatter ShortTime { get; }
  }
}
