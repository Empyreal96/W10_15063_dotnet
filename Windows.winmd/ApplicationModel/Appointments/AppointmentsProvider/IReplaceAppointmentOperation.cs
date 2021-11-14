// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.IReplaceAppointmentOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  [ExclusiveTo(typeof (ReplaceAppointmentOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4103093659, 40545, 19938, 167, 50, 38, 135, 192, 125, 29, 232)]
  internal interface IReplaceAppointmentOperation
  {
    string AppointmentId { get; }

    Appointment AppointmentInformation { get; }

    IReference<DateTime> InstanceStartDate { get; }

    string SourcePackageFamilyName { get; }

    void ReportCompleted(string itemId);

    void ReportCanceled();

    void ReportError(string value);

    void DismissUI();
  }
}
