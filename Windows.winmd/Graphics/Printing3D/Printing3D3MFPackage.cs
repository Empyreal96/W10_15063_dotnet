// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3D3MFPackage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing3D
{
  [Static(typeof (IPrinting3D3MFPackageStatics), 65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Graphics.Printing3D.Printing3DContract")]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  public sealed class Printing3D3MFPackage : IPrinting3D3MFPackage
  {
    [MethodImpl]
    public extern Printing3D3MFPackage();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> SaveAsync();

    public extern IRandomAccessStream PrintTicket { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStream ModelPart { [MethodImpl] get; [MethodImpl] set; }

    public extern Printing3DTextureResource Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<Printing3DTextureResource> Textures { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Printing3DModel> LoadModelFromPackageAsync(
      IRandomAccessStream value);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveModelToPackageAsync(Printing3DModel value);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Printing3D3MFPackage> LoadAsync(
      IRandomAccessStream value);
  }
}
