// Decompiled with JetBrains decompiler
// Type: PhoneInternal.CorePlat.Diagnostics.IDiagnosticsControllerStatics
// Assembly: PhoneInternal.CorePlat, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 567D0613-1791-46D6-BCA3-107C5D9EF3FD
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.CorePlat.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.CorePlat.Diagnostics
{
  [ExclusiveTo(typeof (DiagnosticsController))]
  [Guid(2022637683, 61602, 17860, 129, 82, 190, 55, 153, 159, 130, 16)]
  [Version(100859904)]
  internal interface IDiagnosticsControllerStatics
  {
    IAsyncAction CopyFileAsync(string sourceFileName, string destFileName);

    IAsyncAction CopyDirectoryAsync(
      string sourceDirName,
      string destDirName,
      bool copySubdirectories);

    IAsyncAction DumpRegKeyAsync(string regKeyPath, string outputFileName);

    IAsyncAction RunTelemetryUploadAsync(uint timeOut, out uint uploadResult);

    IAsyncOperation<int> GetTelemetryCrashDumpConfigAsync();

    IAsyncAction SetTelemetryCrashDumpConfigAsync(int dumptype, DateTime timeout);

    IAsyncAction RevertTelemetryCrashDumpConfigAsync();
  }
}
