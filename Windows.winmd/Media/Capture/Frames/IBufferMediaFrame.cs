// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IBufferMediaFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3048297415, 39812, 16482, 183, 156, 163, 101, 178, 89, 104, 84)]
  [ExclusiveTo(typeof (BufferMediaFrame))]
  internal interface IBufferMediaFrame
  {
    MediaFrameReference FrameReference { get; }

    IBuffer Buffer { get; }
  }
}
