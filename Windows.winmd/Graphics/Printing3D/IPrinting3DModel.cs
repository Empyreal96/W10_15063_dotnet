// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DModel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [ExclusiveTo(typeof (Printing3DModel))]
  [Guid(755052272, 21243, 37274, 119, 176, 75, 26, 59, 128, 50, 79)]
  internal interface IPrinting3DModel
  {
    Printing3DModelUnit Unit { get; set; }

    IVector<Printing3DModelTexture> Textures { get; }

    IVector<Printing3DMesh> Meshes { get; }

    IVector<Printing3DComponent> Components { get; }

    Printing3DMaterial Material { get; set; }

    Printing3DComponent Build { get; set; }

    string Version { get; set; }

    IVector<string> RequiredExtensions { get; }

    IMap<string, string> Metadata { get; }

    [RemoteAsync]
    IAsyncAction RepairAsync();

    Printing3DModel Clone();
  }
}
