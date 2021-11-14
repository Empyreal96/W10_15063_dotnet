// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.NumeralSystemTranslator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [Activatable(typeof (INumeralSystemTranslatorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NumeralSystemTranslator : INumeralSystemTranslator
  {
    [MethodImpl]
    public extern NumeralSystemTranslator(IIterable<string> languages);

    [MethodImpl]
    public extern NumeralSystemTranslator();

    public extern IVectorView<string> Languages { [MethodImpl] get; }

    public extern string ResolvedLanguage { [MethodImpl] get; }

    public extern string NumeralSystem { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern string TranslateNumerals(string value);
  }
}
