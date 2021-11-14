// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DComponent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DComponent))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(2116581445, 49023, 19675, 162, 127, 48, 160, 20, 55, 254, 222)]
  internal interface IPrinting3DComponent
  {
    Printing3DMesh Mesh { get; set; }

    IVector<Printing3DComponentWithMatrix> Components { get; }

    Printing3DTextureResource Thumbnail { get; set; }

    Printing3DObjectType Type { get; set; }

    string Name { get; set; }

    string PartNumber { get; set; }
  }
}
