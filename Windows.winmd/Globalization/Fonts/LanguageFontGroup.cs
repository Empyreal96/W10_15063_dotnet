// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Fonts.LanguageFontGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Fonts
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (ILanguageFontGroupFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LanguageFontGroup : ILanguageFontGroup
  {
    [MethodImpl]
    public extern LanguageFontGroup(string languageTag);

    public extern LanguageFont UITextFont { [MethodImpl] get; }

    public extern LanguageFont UIHeadingFont { [MethodImpl] get; }

    public extern LanguageFont UITitleFont { [MethodImpl] get; }

    public extern LanguageFont UICaptionFont { [MethodImpl] get; }

    public extern LanguageFont UINotificationHeadingFont { [MethodImpl] get; }

    public extern LanguageFont TraditionalDocumentFont { [MethodImpl] get; }

    public extern LanguageFont ModernDocumentFont { [MethodImpl] get; }

    public extern LanguageFont DocumentHeadingFont { [MethodImpl] get; }

    public extern LanguageFont FixedWidthTextFont { [MethodImpl] get; }

    public extern LanguageFont DocumentAlternate1Font { [MethodImpl] get; }

    public extern LanguageFont DocumentAlternate2Font { [MethodImpl] get; }
  }
}
