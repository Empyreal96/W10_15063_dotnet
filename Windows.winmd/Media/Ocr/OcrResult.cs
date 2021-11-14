// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.OcrResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Ocr
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class OcrResult : IOcrResult
  {
    public extern IVectorView<OcrLine> Lines { [MethodImpl] get; }

    public extern IReference<double> TextAngle { [MethodImpl] get; }

    public extern string Text { [MethodImpl] get; }
  }
}
