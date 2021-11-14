// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Fonts.ILanguageFont
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Windows.Globalization.Fonts
{
  [Guid(2972605498, 46957, 17819, 190, 235, 144, 17, 81, 205, 119, 209)]
  [ExclusiveTo(typeof (LanguageFont))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILanguageFont
  {
    string FontFamily { get; }

    FontWeight FontWeight { get; }

    FontStretch FontStretch { get; }

    FontStyle FontStyle { get; }

    double ScaleFactor { get; }
  }
}
