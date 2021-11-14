// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Language
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [DualApiPartition(version = 100794368)]
  [Static(typeof (ILanguageStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ILanguageStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ILanguageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Language : ILanguage, ILanguageExtensionSubtags
  {
    [MethodImpl]
    public extern Language(string languageTag);

    public extern string LanguageTag { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern string NativeName { [MethodImpl] get; }

    public extern string Script { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<string> GetExtensionSubtags(string singleton);

    [MethodImpl]
    public static extern bool TrySetInputMethodLanguageTag(string languageTag);

    [MethodImpl]
    public static extern bool IsWellFormed(string languageTag);

    public static extern string CurrentInputMethodLanguageTag { [MethodImpl] get; }
  }
}
