// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskInstance
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2254166650, 8664, 17779, 143, 50, 146, 138, 27, 6, 65, 246)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBackgroundTaskInstance
  {
    Guid InstanceId { get; }

    BackgroundTaskRegistration Task { get; }

    uint Progress { get; set; }

    object TriggerDetails { get; }

    event BackgroundTaskCanceledEventHandler Canceled;

    uint SuspendedCount { get; }

    BackgroundTaskDeferral GetDeferral();
  }
}
