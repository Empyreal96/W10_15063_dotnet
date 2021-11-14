// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoStreamDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [Guid(317590869, 39979, 17472, 128, 87, 44, 122, 144, 240, 203, 236)]
  [ExclusiveTo(typeof (VideoStreamDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoStreamDescriptor : IMediaStreamDescriptor
  {
    VideoEncodingProperties EncodingProperties { get; }
  }
}
