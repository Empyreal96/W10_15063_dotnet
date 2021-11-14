// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.IAddAppointmentOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3964312307, 25101, 19561, 173, 215, 151, 148, 233, 24, 8, 31)]
  [ExclusiveTo(typeof (AddAppointmentOperation))]
  internal interface IAddAppointmentOperation
  {
    Appointment AppointmentInformation { get; }

    string SourcePackageFamilyName { get; }

    void ReportCompleted(string itemId);

    void ReportCanceled();

    void ReportError(string value);

    void DismissUI();
  }
}
