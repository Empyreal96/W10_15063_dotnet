// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentStoreChangeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2334394865, 26099, 17056, 150, 29, 76, 32, 155, 243, 3, 112)]
  [ExclusiveTo(typeof (AppointmentStoreChangeReader))]
  internal interface IAppointmentStoreChangeReader
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppointmentStoreChange>> ReadBatchAsync();

    void AcceptChanges();

    void AcceptChangesThrough(AppointmentStoreChange lastChangeToAccept);
  }
}
