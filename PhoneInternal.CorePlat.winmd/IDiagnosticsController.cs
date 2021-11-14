// Decompiled with JetBrains decompiler
// Type: PhoneInternal.CorePlat.Diagnostics.IDiagnosticsController
// Assembly: PhoneInternal.CorePlat, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 567D0613-1791-46D6-BCA3-107C5D9EF3FD
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.CorePlat.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.CorePlat.Diagnostics
{
  [Version(100859904)]
  [Guid(1013148120, 52541, 19491, 184, 152, 25, 3, 215, 34, 91, 122)]
  [ExclusiveTo(typeof (DiagnosticsController))]
  internal interface IDiagnosticsController : IClosable
  {
    [Overload("StartProfileAsync")]
    IAsyncAction StartProfileAsync(
      IIterable<string> profileXmls,
      string outputFileName,
      DateTime timeout);

    [Overload("StopProfileAsync")]
    IAsyncAction StopProfileAsync();

    IAsyncAction CancelProfileAsync();

    DateTime TraceTimeout { get; }

    IAsyncOperation<bool> GetNetlogAvailabilityAsync();

    IAsyncAction StartNetlogAsync(string outputFileName);

    IAsyncAction StopNetlogAsync();
  }
}
