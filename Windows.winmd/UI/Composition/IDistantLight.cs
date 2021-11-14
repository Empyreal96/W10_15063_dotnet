// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IDistantLight
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(831322876, 23779, 19285, 171, 93, 7, 160, 3, 83, 172, 153)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DistantLight))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IDistantLight
  {
    Color Color { get; set; }

    Visual CoordinateSpace { get; set; }

    Vector3 Direction { get; set; }
  }
}
