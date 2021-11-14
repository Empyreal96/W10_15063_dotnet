// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.LocalLocationHoursOfOperationItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Services.Maps.LocalSearch
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (LocalSearchContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class LocalLocationHoursOfOperationItem : ILocalLocationHoursOfOperationItem
  {
    public extern DayOfWeek Day { [MethodImpl] get; }

    public extern TimeSpan Start { [MethodImpl] get; }

    public extern TimeSpan Span { [MethodImpl] get; }
  }
}
