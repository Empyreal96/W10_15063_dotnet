// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.AlternateWordForm
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class AlternateWordForm : IAlternateWordForm
  {
    public extern TextSegment SourceTextSegment { [MethodImpl] get; }

    public extern string AlternateText { [MethodImpl] get; }

    public extern AlternateNormalizationFormat NormalizationFormat { [MethodImpl] get; }
  }
}
