// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DFaceReductionOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 196608)]
  [ExclusiveTo(typeof (Printing3DFaceReductionOptions))]
  [Guid(3154039703, 11636, 18167, 190, 133, 153, 166, 123, 187, 102, 41)]
  internal interface IPrinting3DFaceReductionOptions
  {
    double MaxReductionArea { get; set; }

    uint TargetTriangleCount { get; set; }

    double MaxEdgeLength { get; set; }
  }
}
