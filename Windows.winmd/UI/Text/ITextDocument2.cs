// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextDocument2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RichEditTextDocument))]
  [Guid(4063301906, 35977, 18889, 145, 24, 240, 87, 203, 184, 20, 238)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ITextDocument2 : ITextDocument
  {
    bool AlignmentIncludesTrailingWhitespace { get; set; }

    bool IgnoreTrailingCharacterSpacing { get; set; }
  }
}
