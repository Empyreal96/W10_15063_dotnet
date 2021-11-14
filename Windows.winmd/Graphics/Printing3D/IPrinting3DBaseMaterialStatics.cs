// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrinting3DBaseMaterialStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Printing3DBaseMaterial))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(2170177468, 14154, 18285, 190, 146, 62, 207, 209, 203, 151, 118)]
  internal interface IPrinting3DBaseMaterialStatics
  {
    string Abs { get; }

    string Pla { get; }
  }
}
