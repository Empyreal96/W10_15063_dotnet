// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IActivitySensorTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(3504161602, 58235, 18467, 165, 254, 107, 49, 223, 239, 222, 176)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ActivitySensorTrigger))]
  internal interface IActivitySensorTrigger : IBackgroundTrigger
  {
    IVector<ActivityType> SubscribedActivities { get; }

    uint ReportInterval { get; }

    IVectorView<ActivityType> SupportedActivities { get; }

    uint MinimumReportInterval { get; }
  }
}
