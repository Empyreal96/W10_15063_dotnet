// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  [Guid(3896180834, 55158, 20370, 186, 234, 64, 231, 125, 71, 145, 213)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextElement))]
  internal interface ITextElement
  {
    string Name { get; }

    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }

    FontStretch FontStretch { get; set; }

    int CharacterSpacing { get; set; }

    Brush Foreground { get; set; }

    string Language { get; set; }

    TextPointer ContentStart { get; }

    TextPointer ContentEnd { get; }

    TextPointer ElementStart { get; }

    TextPointer ElementEnd { get; }

    object FindName(string name);
  }
}
