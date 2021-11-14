// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingProperties4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  [Guid(1917775892, 49420, 16626, 157, 114, 62, 225, 59, 69, 250, 142)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IVideoEncodingProperties4
  {
    SphericalVideoFrameFormat SphericalVideoFrameFormat { get; }
  }
}
