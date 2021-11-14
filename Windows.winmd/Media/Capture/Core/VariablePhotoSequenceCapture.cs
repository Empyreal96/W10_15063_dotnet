// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Core.VariablePhotoSequenceCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  public sealed class VariablePhotoSequenceCapture : 
    IVariablePhotoSequenceCapture,
    IVariablePhotoSequenceCapture2
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FinishAsync();

    public extern event TypedEventHandler<VariablePhotoSequenceCapture, VariablePhotoCapturedEventArgs> PhotoCaptured;

    public extern event TypedEventHandler<VariablePhotoSequenceCapture, object> Stopped;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateSettingsAsync();
  }
}
