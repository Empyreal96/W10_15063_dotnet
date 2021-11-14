// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokesErasedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [WebHostHidden]
  [ExclusiveTo(typeof (InkStrokesErasedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2753653282, 5379, 20159, 143, 245, 45, 232, 69, 132, 168, 170)]
  internal interface IInkStrokesErasedEventArgs
  {
    IVectorView<InkStroke> Strokes { get; }
  }
}
