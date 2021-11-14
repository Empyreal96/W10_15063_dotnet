// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DCompositeMaterialGroup2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DCompositeMaterialGroup))]
  [ContractVersion(typeof (Printing3DContract), 196608)]
  [Guid(115895650, 32059, 16865, 148, 76, 186, 253, 228, 85, 84, 131)]
  internal interface IPrinting3DCompositeMaterialGroup2
  {
    Printing3DBaseMaterialGroup BaseMaterialGroup { get; set; }
  }
}
