// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.IRemoveAppointmentOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  [ExclusiveTo(typeof (RemoveAppointmentOperation))]
  [Guid(146172602, 65075, 18125, 165, 12, 168, 255, 179, 38, 5, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRemoveAppointmentOperation
  {
    string AppointmentId { get; }

    IReference<DateTime> InstanceStartDate { get; }

    string SourcePackageFamilyName { get; }

    void ReportCompleted();

    void ReportCanceled();

    void ReportError(string value);

    void DismissUI();
  }
}
