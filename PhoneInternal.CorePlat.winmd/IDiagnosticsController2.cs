// Decompiled with JetBrains decompiler
// Type: PhoneInternal.CorePlat.Diagnostics.IDiagnosticsController2
// Assembly: PhoneInternal.CorePlat, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 567D0613-1791-46D6-BCA3-107C5D9EF3FD
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.CorePlat.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.CorePlat.Diagnostics
{
  [Version(100859904)]
  [ExclusiveTo(typeof (DiagnosticsController))]
  [Guid(581062665, 65238, 20427, 174, 130, 204, 226, 124, 81, 159, 57)]
  internal interface IDiagnosticsController2 : IClosable
  {
    [Overload("StartProfileWithShutdownTracingAsync")]
    IAsyncAction StartProfileAsync(
      IIterable<string> profileXmls,
      string outputFileName,
      DateTime timeout,
      bool doShutdownTracing);

    [Overload("StopProfileWithShutdownTracingAsync")]
    IAsyncAction StopProfileAsync(bool isShutdownTracing);

    void VerifyShutdownTracingIsSupported();
  }
}
