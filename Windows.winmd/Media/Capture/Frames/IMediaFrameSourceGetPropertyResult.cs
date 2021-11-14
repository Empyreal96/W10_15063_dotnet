// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceGetPropertyResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MediaFrameSourceGetPropertyResult))]
  [Guid(143005378, 14948, 19413, 189, 43, 231, 200, 152, 210, 243, 122)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaFrameSourceGetPropertyResult
  {
    MediaFrameSourceGetPropertyStatus Status { get; }

    object Value { [return: Variant] get; }
  }
}
