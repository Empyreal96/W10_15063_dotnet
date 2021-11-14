// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.WordSegmentsTokenizingHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(2782749527, 48938, 19535, 163, 31, 41, 231, 28, 111, 139, 53)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void WordSegmentsTokenizingHandler(
    IIterable<WordSegment> precedingWords,
    IIterable<WordSegment> words);
}
