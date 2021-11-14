// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IThumbnailProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ExclusiveTo(typeof (StorageItemThumbnail))]
  [Guid(1765659695, 56295, 18869, 179, 179, 40, 147, 172, 93, 52, 35)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IThumbnailProperties
  {
    uint OriginalWidth { get; }

    uint OriginalHeight { get; }

    bool ReturnedSmallerCachedSize { get; }

    ThumbnailType Type { get; }
  }
}
