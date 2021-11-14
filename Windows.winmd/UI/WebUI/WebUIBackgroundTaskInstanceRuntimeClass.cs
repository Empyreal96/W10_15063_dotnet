// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIBackgroundTaskInstanceRuntimeClass
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebUIBackgroundTaskInstanceRuntimeClass : 
    IWebUIBackgroundTaskInstance,
    IBackgroundTaskInstance
  {
    public extern bool Succeeded { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid InstanceId { [MethodImpl] get; }

    public extern BackgroundTaskRegistration Task { [MethodImpl] get; }

    public extern uint Progress { [MethodImpl] get; [MethodImpl] set; }

    public extern object TriggerDetails { [MethodImpl] get; }

    public extern event BackgroundTaskCanceledEventHandler Canceled;

    public extern uint SuspendedCount { [MethodImpl] get; }

    [MethodImpl]
    public extern BackgroundTaskDeferral GetDeferral();
  }
}
