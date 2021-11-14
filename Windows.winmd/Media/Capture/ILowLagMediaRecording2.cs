// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ILowLagMediaRecording2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (LowLagMediaRecording))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1667876696, 22084, 16866, 151, 175, 142, 245, 106, 37, 226, 37)]
  internal interface ILowLagMediaRecording2
  {
    [RemoteAsync]
    IAsyncAction PauseAsync(MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    IAsyncAction ResumeAsync();
  }
}
