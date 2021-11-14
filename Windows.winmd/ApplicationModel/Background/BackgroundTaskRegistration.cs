// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskRegistration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBackgroundTaskRegistrationStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBackgroundTaskRegistrationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class BackgroundTaskRegistration : 
    IBackgroundTaskRegistration,
    IBackgroundTaskRegistration2,
    IBackgroundTaskRegistration3
  {
    public extern Guid TaskId { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern event BackgroundTaskProgressEventHandler Progress;

    public extern event BackgroundTaskCompletedEventHandler Completed;

    [MethodImpl]
    public extern void Unregister(bool cancelTask);

    public extern IBackgroundTrigger Trigger { [MethodImpl] get; }

    public extern BackgroundTaskRegistrationGroup TaskGroup { [MethodImpl] get; }

    public static extern IMapView<string, BackgroundTaskRegistrationGroup> AllTaskGroups { [MethodImpl] get; }

    [MethodImpl]
    public static extern BackgroundTaskRegistrationGroup GetTaskGroup(
      string groupId);

    public static extern IMapView<Guid, IBackgroundTaskRegistration> AllTasks { [MethodImpl] get; }
  }
}
