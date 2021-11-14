// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistrationGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (BackgroundTaskRegistrationGroup))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(716280218, 34587, 16743, 138, 118, 5, 92, 214, 123, 91, 35)]
  internal interface IBackgroundTaskRegistrationGroup
  {
    string Id { get; }

    string Name { get; }

    event TypedEventHandler<BackgroundTaskRegistrationGroup, BackgroundActivatedEventArgs> BackgroundActivated;

    IMapView<Guid, BackgroundTaskRegistration> AllTasks { get; }
  }
}
