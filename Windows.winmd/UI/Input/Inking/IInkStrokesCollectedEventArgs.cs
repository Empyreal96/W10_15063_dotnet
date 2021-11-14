// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokesCollectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3304321577, 6456, 18780, 180, 217, 109, 228, 176, 141, 72, 17)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InkStrokesCollectedEventArgs))]
  internal interface IInkStrokesCollectedEventArgs
  {
    IVectorView<InkStroke> Strokes { get; }
  }
}
