// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IFindAppointmentsOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (FindAppointmentsOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1442307157, 39234, 12422, 130, 181, 44, 178, 159, 100, 213, 245)]
  internal interface IFindAppointmentsOptions
  {
    IVector<string> CalendarIds { get; }

    IVector<string> FetchProperties { get; }

    bool IncludeHidden { get; set; }

    uint MaxCount { get; set; }
  }
}
