// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.WordSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class WordSegment : IWordSegment
  {
    public extern string Text { [MethodImpl] get; }

    public extern TextSegment SourceTextSegment { [MethodImpl] get; }

    public extern IVectorView<AlternateWordForm> AlternateForms { [MethodImpl] get; }
  }
}
