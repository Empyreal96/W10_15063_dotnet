// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointment3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (Appointment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3217835433, 35169, 18833, 147, 75, 196, 135, 104, 229, 169, 108)]
  internal interface IAppointment3 : IAppointment2, IAppointment
  {
    ulong ChangeNumber { get; }

    ulong RemoteChangeNumber { get; set; }

    AppointmentDetailsKind DetailsKind { get; set; }
  }
}
