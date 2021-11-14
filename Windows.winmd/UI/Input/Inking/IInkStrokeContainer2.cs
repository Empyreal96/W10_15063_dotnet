// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeContainer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkStrokeContainer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2298598244, 55862, 19407, 158, 92, 209, 149, 130, 89, 149, 180)]
  internal interface IInkStrokeContainer2
  {
    void AddStrokes(IIterable<InkStroke> strokes);

    void Clear();
  }
}
