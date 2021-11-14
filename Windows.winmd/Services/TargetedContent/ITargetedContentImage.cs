// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentImage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Services.TargetedContent
{
  [ExclusiveTo(typeof (TargetedContentImage))]
  [Guid(2812642777, 30623, 19230, 187, 177, 142, 175, 83, 251, 234, 178)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  internal interface ITargetedContentImage : IRandomAccessStreamReference
  {
    uint Height { get; }

    uint Width { get; }
  }
}
