// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(798679196, 45900, 19911, 163, 93, 202, 253, 136, 174, 62, 198)]
  [ExclusiveTo(typeof (AppointmentManager))]
  internal interface IAppointmentManagerStatics3
  {
    AppointmentManagerForUser GetForUser(User user);
  }
}
