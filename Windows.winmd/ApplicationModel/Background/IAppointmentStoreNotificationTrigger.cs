// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IAppointmentStoreNotificationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentStoreNotificationTrigger))]
  [Guid(1691616268, 49665, 17069, 170, 42, 226, 27, 163, 66, 91, 109)]
  internal interface IAppointmentStoreNotificationTrigger : IBackgroundTrigger
  {
  }
}
