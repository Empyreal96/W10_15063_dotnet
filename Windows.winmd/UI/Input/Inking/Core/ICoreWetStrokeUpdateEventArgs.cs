// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreWetStrokeUpdateEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreWetStrokeUpdateEventArgs))]
  [Guid(4211593548, 13184, 17786, 169, 135, 153, 19, 87, 137, 108, 27)]
  internal interface ICoreWetStrokeUpdateEventArgs
  {
    IVector<InkPoint> NewInkPoints { get; }

    uint PointerId { get; }

    CoreWetStrokeDisposition Disposition { get; set; }
  }
}
