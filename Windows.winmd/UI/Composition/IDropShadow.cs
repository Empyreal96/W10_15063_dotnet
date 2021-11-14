// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IDropShadow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DropShadow))]
  [Guid(3415702535, 41300, 18513, 133, 231, 168, 146, 76, 132, 250, 216)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IDropShadow
  {
    float BlurRadius { get; set; }

    Color Color { get; set; }

    CompositionBrush Mask { get; set; }

    Vector3 Offset { get; set; }

    float Opacity { get; set; }
  }
}
