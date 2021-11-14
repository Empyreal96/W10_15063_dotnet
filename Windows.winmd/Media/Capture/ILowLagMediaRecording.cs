// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ILowLagMediaRecording
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (LowLagMediaRecording))]
  [Guid(1103674103, 65343, 18928, 164, 119, 241, 149, 227, 206, 81, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILowLagMediaRecording
  {
    [RemoteAsync]
    IAsyncAction StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();

    [RemoteAsync]
    IAsyncAction FinishAsync();
  }
}
