// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IBackgroundTaskRegistrationGroupFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BackgroundTaskRegistrationGroup : IBackgroundTaskRegistrationGroup
  {
    [MethodImpl]
    public extern BackgroundTaskRegistrationGroup(string id);

    [MethodImpl]
    public extern BackgroundTaskRegistrationGroup(string id, string name);

    public extern string Id { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern event TypedEventHandler<BackgroundTaskRegistrationGroup, BackgroundActivatedEventArgs> BackgroundActivated;

    public extern IMapView<Guid, BackgroundTaskRegistration> AllTasks { [MethodImpl] get; }
  }
}
