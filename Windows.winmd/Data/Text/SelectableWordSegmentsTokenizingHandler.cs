// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.SelectableWordSegmentsTokenizingHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(977140892, 44766, 19911, 158, 108, 65, 192, 68, 189, 53, 146)]
  public delegate void SelectableWordSegmentsTokenizingHandler(
    IIterable<SelectableWordSegment> precedingWords,
    IIterable<SelectableWordSegment> words);
}
