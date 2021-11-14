// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.AppointmentsProviderLaunchActionVerbs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  [Static(typeof (IAppointmentsProviderLaunchActionVerbsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAppointmentsProviderLaunchActionVerbsStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class AppointmentsProviderLaunchActionVerbs
  {
    public static extern string ShowAppointmentDetails { [MethodImpl] get; }

    public static extern string AddAppointment { [MethodImpl] get; }

    public static extern string ReplaceAppointment { [MethodImpl] get; }

    public static extern string RemoveAppointment { [MethodImpl] get; }

    public static extern string ShowTimeFrame { [MethodImpl] get; }
  }
}
