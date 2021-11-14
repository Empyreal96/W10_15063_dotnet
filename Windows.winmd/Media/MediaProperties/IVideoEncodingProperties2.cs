// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingProperties2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  [Guid(4148404719, 54373, 17040, 169, 75, 239, 15, 21, 40, 248, 227)]
  internal interface IVideoEncodingProperties2
  {
    void SetFormatUserData(byte[] value);

    void GetFormatUserData(out byte[] value);

    int ProfileId { set; get; }
  }
}
