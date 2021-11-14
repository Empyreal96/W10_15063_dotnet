﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ApplicationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ApplicationTrigger : IApplicationTrigger, IBackgroundTrigger
  {
    [MethodImpl]
    public extern ApplicationTrigger();

    [Overload("RequestAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ApplicationTriggerResult> RequestAsync();

    [Overload("RequestAsyncWithArguments")]
    [MethodImpl]
    public extern IAsyncOperation<ApplicationTriggerResult> RequestAsync(
      ValueSet arguments);
  }
}
