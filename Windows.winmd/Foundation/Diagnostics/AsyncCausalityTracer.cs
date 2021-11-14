// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.AsyncCausalityTracer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAsyncCausalityTracerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100859904)]
  public static class AsyncCausalityTracer
  {
    [MethodImpl]
    public static extern void TraceOperationCreation(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      string operationName,
      ulong relatedContext);

    [MethodImpl]
    public static extern void TraceOperationCompletion(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      AsyncStatus status);

    [MethodImpl]
    public static extern void TraceOperationRelation(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      CausalityRelation relation);

    [MethodImpl]
    public static extern void TraceSynchronousWorkStart(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      CausalitySynchronousWork work);

    [MethodImpl]
    public static extern void TraceSynchronousWorkCompletion(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      CausalitySynchronousWork work);

    public static extern event EventHandler<TracingStatusChangedEventArgs> TracingStatusChanged;
  }
}
