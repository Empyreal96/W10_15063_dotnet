// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.ReplaceAppointmentOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ReplaceAppointmentOperation : IReplaceAppointmentOperation
  {
    public extern string AppointmentId { [MethodImpl] get; }

    public extern Appointment AppointmentInformation { [MethodImpl] get; }

    public extern IReference<DateTime> InstanceStartDate { [MethodImpl] get; }

    public extern string SourcePackageFamilyName { [MethodImpl] get; }

    [MethodImpl]
    public extern void ReportCompleted(string itemId);

    [MethodImpl]
    public extern void ReportCanceled();

    [MethodImpl]
    public extern void ReportError(string value);

    [MethodImpl]
    public extern void DismissUI();
  }
}
