// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3D3MFPackage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing3D
{
  [Guid(4132296136, 10935, 17833, 161, 183, 38, 126, 148, 141, 91, 24)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [ExclusiveTo(typeof (Printing3D3MFPackage))]
  internal interface IPrinting3D3MFPackage
  {
    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> SaveAsync();

    IRandomAccessStream PrintTicket { get; set; }

    IRandomAccessStream ModelPart { get; set; }

    Printing3DTextureResource Thumbnail { get; set; }

    IVector<Printing3DTextureResource> Textures { get; }

    [RemoteAsync]
    IAsyncOperation<Printing3DModel> LoadModelFromPackageAsync(
      IRandomAccessStream value);

    [RemoteAsync]
    IAsyncAction SaveModelToPackageAsync(Printing3DModel value);
  }
}
