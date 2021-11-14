// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.FindAppointmentsOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FindAppointmentsOptions : IFindAppointmentsOptions
  {
    [MethodImpl]
    public extern FindAppointmentsOptions();

    public extern IVector<string> CalendarIds { [MethodImpl] get; }

    public extern IVector<string> FetchProperties { [MethodImpl] get; }

    public extern bool IncludeHidden { [MethodImpl] get; [MethodImpl] set; }

    public extern uint MaxCount { [MethodImpl] get; [MethodImpl] set; }
  }
}
