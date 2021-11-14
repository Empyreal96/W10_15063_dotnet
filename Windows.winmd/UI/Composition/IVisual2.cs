// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVisual2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (Visual))]
  [Guid(810726929, 22211, 19518, 139, 243, 246, 225, 173, 71, 63, 6)]
  [WebHostHidden]
  internal interface IVisual2
  {
    Visual ParentForTransform { get; set; }

    Vector3 RelativeOffsetAdjustment { get; set; }

    Vector2 RelativeSizeAdjustment { get; set; }
  }
}
