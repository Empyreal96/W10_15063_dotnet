// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentDataProviderTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3005758465, 32274, 20062, 177, 239, 116, 251, 104, 172, 111, 42)]
  [ExclusiveTo(typeof (AppointmentDataProviderTriggerDetails))]
  internal interface IAppointmentDataProviderTriggerDetails
  {
    AppointmentDataProviderConnection Connection { get; }
  }
}
