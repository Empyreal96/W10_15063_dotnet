// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IGlyphs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  [Guid(3497609611, 62129, 17025, 153, 162, 228, 208, 89, 50, 178, 181)]
  [ExclusiveTo(typeof (Glyphs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGlyphs
  {
    string UnicodeString { get; set; }

    string Indices { get; set; }

    Uri FontUri { get; set; }

    StyleSimulations StyleSimulations { get; set; }

    double FontRenderingEmSize { get; set; }

    double OriginX { get; set; }

    double OriginY { get; set; }

    Brush Fill { get; set; }
  }
}
