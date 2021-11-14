// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.IAppointmentsProviderLaunchActionVerbsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(920369704, 40494, 18886, 142, 247, 58, 183, 165, 220, 200, 184)]
  [ExclusiveTo(typeof (AppointmentsProviderLaunchActionVerbs))]
  internal interface IAppointmentsProviderLaunchActionVerbsStatics
  {
    string AddAppointment { get; }

    string ReplaceAppointment { get; }

    string RemoveAppointment { get; }

    string ShowTimeFrame { get; }
  }
}
