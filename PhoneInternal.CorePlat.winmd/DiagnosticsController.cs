// Decompiled with JetBrains decompiler
// Type: PhoneInternal.CorePlat.Diagnostics.DiagnosticsController
// Assembly: PhoneInternal.CorePlat, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 567D0613-1791-46D6-BCA3-107C5D9EF3FD
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.CorePlat.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.CorePlat.Diagnostics
{
  [Static(typeof (IDiagnosticsControllerStatics), 100859904)]
  [Activatable(typeof (IDiagnosticsControllerFactory), 100859904)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DiagnosticsController : 
    IDiagnosticsController,
    IClosable,
    IDiagnosticsController2
  {
    [MethodImpl]
    public extern DiagnosticsController(string appName);

    [Overload("StartProfileAsync")]
    [MethodImpl]
    public extern IAsyncAction StartProfileAsync(
      IIterable<string> profileXmls,
      string outputFileName,
      DateTime timeout);

    [Overload("StopProfileAsync")]
    [MethodImpl]
    public extern IAsyncAction StopProfileAsync();

    [MethodImpl]
    public extern IAsyncAction CancelProfileAsync();

    public extern DateTime TraceTimeout { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<bool> GetNetlogAvailabilityAsync();

    [MethodImpl]
    public extern IAsyncAction StartNetlogAsync(string outputFileName);

    [MethodImpl]
    public extern IAsyncAction StopNetlogAsync();

    [MethodImpl]
    public extern void Close();

    [Overload("StartProfileWithShutdownTracingAsync")]
    [MethodImpl]
    public extern IAsyncAction StartProfileAsync(
      IIterable<string> profileXmls,
      string outputFileName,
      DateTime timeout,
      bool doShutdownTracing);

    [Overload("StopProfileWithShutdownTracingAsync")]
    [MethodImpl]
    public extern IAsyncAction StopProfileAsync(bool isShutdownTracing);

    [MethodImpl]
    public extern void VerifyShutdownTracingIsSupported();

    [MethodImpl]
    public static extern IAsyncAction CopyFileAsync(
      string sourceFileName,
      string destFileName);

    [MethodImpl]
    public static extern IAsyncAction CopyDirectoryAsync(
      string sourceDirName,
      string destDirName,
      bool copySubdirectories);

    [MethodImpl]
    public static extern IAsyncAction DumpRegKeyAsync(
      string regKeyPath,
      string outputFileName);

    [MethodImpl]
    public static extern IAsyncAction RunTelemetryUploadAsync(
      uint timeOut,
      out uint uploadResult);

    [MethodImpl]
    public static extern IAsyncOperation<int> GetTelemetryCrashDumpConfigAsync();

    [MethodImpl]
    public static extern IAsyncAction SetTelemetryCrashDumpConfigAsync(
      int dumptype,
      DateTime timeout);

    [MethodImpl]
    public static extern IAsyncAction RevertTelemetryCrashDumpConfigAsync();
  }
}
