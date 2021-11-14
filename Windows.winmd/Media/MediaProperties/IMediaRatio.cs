// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaRatio
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(3536912101, 35113, 16413, 172, 120, 125, 53, 126, 55, 129, 99)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaRatio))]
  internal interface IMediaRatio
  {
    uint Numerator { set; get; }

    uint Denominator { set; get; }
  }
}
