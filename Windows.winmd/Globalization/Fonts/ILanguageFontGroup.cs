// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Fonts.ILanguageFontGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Fonts
{
  [Guid(4080697283, 14940, 19178, 185, 255, 179, 159, 178, 66, 247, 246)]
  [ExclusiveTo(typeof (LanguageFontGroup))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILanguageFontGroup
  {
    LanguageFont UITextFont { get; }

    LanguageFont UIHeadingFont { get; }

    LanguageFont UITitleFont { get; }

    LanguageFont UICaptionFont { get; }

    LanguageFont UINotificationHeadingFont { get; }

    LanguageFont TraditionalDocumentFont { get; }

    LanguageFont ModernDocumentFont { get; }

    LanguageFont DocumentHeadingFont { get; }

    LanguageFont FixedWidthTextFont { get; }

    LanguageFont DocumentAlternate1Font { get; }

    LanguageFont DocumentAlternate2Font { get; }
  }
}
