// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IAsyncCausalityTracerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (AsyncCausalityTracer))]
  [Guid(1350896422, 9854, 17691, 168, 144, 171, 106, 55, 2, 69, 238)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAsyncCausalityTracerStatics
  {
    void TraceOperationCreation(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      string operationName,
      ulong relatedContext);

    void TraceOperationCompletion(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      AsyncStatus status);

    void TraceOperationRelation(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      CausalityRelation relation);

    void TraceSynchronousWorkStart(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      CausalitySynchronousWork work);

    void TraceSynchronousWorkCompletion(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      CausalitySynchronousWork work);

    event EventHandler<TracingStatusChangedEventArgs> TracingStatusChanged;
  }
}
