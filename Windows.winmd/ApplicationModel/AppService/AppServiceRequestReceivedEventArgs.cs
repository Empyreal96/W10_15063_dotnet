﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceRequestReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class AppServiceRequestReceivedEventArgs : IAppServiceRequestReceivedEventArgs
  {
    public extern AppServiceRequest Request { [MethodImpl] get; }

    [MethodImpl]
    public extern AppServiceDeferral GetDeferral();
  }
}
