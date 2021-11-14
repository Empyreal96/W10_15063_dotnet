// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DCompositeMaterial
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Guid(1176647901, 22062, 20332, 136, 45, 244, 216, 65, 253, 99, 199)]
  [ExclusiveTo(typeof (Printing3DCompositeMaterial))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrinting3DCompositeMaterial
  {
    IVector<double> Values { get; }
  }
}
