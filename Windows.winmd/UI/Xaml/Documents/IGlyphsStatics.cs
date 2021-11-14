// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IGlyphsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Glyphs))]
  [Guid(576517317, 65009, 17389, 149, 143, 65, 78, 134, 241, 3, 242)]
  [WebHostHidden]
  internal interface IGlyphsStatics
  {
    DependencyProperty UnicodeStringProperty { get; }

    DependencyProperty IndicesProperty { get; }

    DependencyProperty FontUriProperty { get; }

    DependencyProperty StyleSimulationsProperty { get; }

    DependencyProperty FontRenderingEmSizeProperty { get; }

    DependencyProperty OriginXProperty { get; }

    DependencyProperty OriginYProperty { get; }

    DependencyProperty FillProperty { get; }
  }
}
