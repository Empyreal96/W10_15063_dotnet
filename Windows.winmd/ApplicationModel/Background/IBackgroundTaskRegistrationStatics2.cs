// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistrationStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (BackgroundTaskRegistration))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(390817566, 45581, 20393, 173, 154, 233, 58, 214, 199, 30, 1)]
  internal interface IBackgroundTaskRegistrationStatics2
  {
    IMapView<string, BackgroundTaskRegistrationGroup> AllTaskGroups { get; }

    BackgroundTaskRegistrationGroup GetTaskGroup(string groupId);
  }
}
