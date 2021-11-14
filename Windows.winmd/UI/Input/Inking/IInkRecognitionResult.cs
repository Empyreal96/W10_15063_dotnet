// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkRecognitionResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(910563988, 20584, 16623, 138, 5, 44, 47, 182, 9, 8, 162)]
  [ExclusiveTo(typeof (InkRecognitionResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInkRecognitionResult
  {
    Rect BoundingRect { get; }

    IVectorView<string> GetTextCandidates();

    IVectorView<InkStroke> GetStrokes();
  }
}
