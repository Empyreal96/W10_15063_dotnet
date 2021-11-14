// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Fonts.LanguageFont
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Windows.Globalization.Fonts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LanguageFont : ILanguageFont
  {
    public extern string FontFamily { [MethodImpl] get; }

    public extern FontWeight FontWeight { [MethodImpl] get; }

    public extern FontStretch FontStretch { [MethodImpl] get; }

    public extern FontStyle FontStyle { [MethodImpl] get; }

    public extern double ScaleFactor { [MethodImpl] get; }
  }
}
