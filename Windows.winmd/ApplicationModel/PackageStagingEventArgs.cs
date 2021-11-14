// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageStagingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PackageStagingEventArgs : IPackageStagingEventArgs
  {
    public extern Guid ActivityId { [MethodImpl] get; }

    public extern Package Package { [MethodImpl] get; }

    public extern double Progress { [MethodImpl] get; }

    public extern bool IsComplete { [MethodImpl] get; }

    public extern HResult ErrorCode { [MethodImpl] get; }
  }
}
