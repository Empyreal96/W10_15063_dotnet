// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingPropertiesStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3474898269, 18942, 19712, 181, 154, 207, 164, 223, 197, 25, 68)]
  internal interface IVideoEncodingPropertiesStatics2
  {
    VideoEncodingProperties CreateHevc();
  }
}
