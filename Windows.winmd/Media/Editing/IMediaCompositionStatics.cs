// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaCompositionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Editing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaComposition))]
  [Guid(2275446532, 58154, 17870, 143, 102, 163, 13, 240, 118, 98, 36)]
  internal interface IMediaCompositionStatics
  {
    [RemoteAsync]
    IAsyncOperation<MediaComposition> LoadAsync(StorageFile file);
  }
}
