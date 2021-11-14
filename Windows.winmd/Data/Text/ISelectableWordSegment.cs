// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ISelectableWordSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2439662775, 35495, 19576, 179, 116, 93, 237, 183, 82, 230, 11)]
  [ExclusiveTo(typeof (SelectableWordSegment))]
  internal interface ISelectableWordSegment
  {
    string Text { get; }

    TextSegment SourceTextSegment { get; }
  }
}
