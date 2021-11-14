// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumeralSystemTranslatorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2519779546, 14063, 19848, 168, 92, 111, 13, 152, 214, 32, 166)]
  [ExclusiveTo(typeof (NumeralSystemTranslator))]
  internal interface INumeralSystemTranslatorFactory
  {
    NumeralSystemTranslator Create(IIterable<string> languages);
  }
}
