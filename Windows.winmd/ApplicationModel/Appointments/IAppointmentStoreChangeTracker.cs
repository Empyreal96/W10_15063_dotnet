// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentStoreChangeTracker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentStoreChangeTracker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(455472305, 36558, 20247, 147, 200, 230, 65, 36, 88, 253, 92)]
  internal interface IAppointmentStoreChangeTracker
  {
    AppointmentStoreChangeReader GetChangeReader();

    void Enable();

    void Reset();
  }
}
