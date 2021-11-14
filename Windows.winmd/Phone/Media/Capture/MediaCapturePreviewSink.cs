// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.MediaCapturePreviewSink
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media;

namespace Windows.Phone.Media.Capture
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Phone.PhoneInternalContract")]
  [Activatable(typeof (IMediaCapturePreviewSinkFactory), 65536, "Windows.Phone.PhoneInternalContract")]
  public sealed class MediaCapturePreviewSink : IMediaExtension, IMediaCapturePreviewSink, IClosable
  {
    [MethodImpl]
    public extern MediaCapturePreviewSink(string connectionPort);

    [MethodImpl]
    public extern MediaCapturePreviewSink();

    [MethodImpl]
    public extern void SetProperties(IPropertySet configuration);

    public extern string ConnectionPort { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
