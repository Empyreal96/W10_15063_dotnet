// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkRecognizerContainer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.None)]
  public sealed class InkRecognizerContainer : IInkRecognizerContainer
  {
    [MethodImpl]
    public extern InkRecognizerContainer();

    [MethodImpl]
    public extern void SetDefaultRecognizer(InkRecognizer recognizer);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync(
      InkStrokeContainer strokeCollection,
      InkRecognitionTarget recognitionTarget);

    [MethodImpl]
    public extern IVectorView<InkRecognizer> GetRecognizers();
  }
}
