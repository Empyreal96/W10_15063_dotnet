// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskProgressEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (BackgroundTaskProgressEventArgs))]
  [Guid(4212418732, 33586, 19722, 149, 50, 3, 234, 230, 132, 218, 49)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundTaskProgressEventArgs
  {
    Guid InstanceId { get; }

    uint Progress { get; }
  }
}
