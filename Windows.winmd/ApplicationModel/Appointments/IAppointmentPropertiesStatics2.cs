// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentPropertiesStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(3757851467, 45079, 17885, 138, 245, 209, 99, 209, 8, 1, 187)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentProperties))]
  internal interface IAppointmentPropertiesStatics2 : IAppointmentPropertiesStatics
  {
    string ChangeNumber { get; }

    string RemoteChangeNumber { get; }

    string DetailsKind { get; }
  }
}
