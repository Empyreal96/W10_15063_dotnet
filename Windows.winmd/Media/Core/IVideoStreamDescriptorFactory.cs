// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoStreamDescriptorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [Guid(1229911761, 47989, 17362, 158, 94, 123, 121, 163, 175, 206, 212)]
  [ExclusiveTo(typeof (VideoStreamDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoStreamDescriptorFactory
  {
    VideoStreamDescriptor Create(VideoEncodingProperties encodingProperties);
  }
}
