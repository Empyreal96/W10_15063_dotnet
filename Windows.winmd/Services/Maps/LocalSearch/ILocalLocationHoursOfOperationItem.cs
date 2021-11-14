// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.ILocalLocationHoursOfOperationItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Services.Maps.LocalSearch
{
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  [ExclusiveTo(typeof (LocalLocationHoursOfOperationItem))]
  [WebHostHidden]
  [Guid(592743538, 41415, 17393, 164, 240, 16, 145, 195, 158, 198, 64)]
  internal interface ILocalLocationHoursOfOperationItem
  {
    DayOfWeek Day { get; }

    TimeSpan Start { get; }

    TimeSpan Span { get; }
  }
}
