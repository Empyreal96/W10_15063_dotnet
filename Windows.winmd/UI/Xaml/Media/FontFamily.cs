// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.FontFamily
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Composable(typeof (IFontFamilyFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IFontFamilyStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  public class FontFamily : IFontFamily
  {
    [MethodImpl]
    public extern FontFamily(string familyName);

    public extern string Source { [MethodImpl] get; }

    public static extern FontFamily XamlAutoFontFamily { [MethodImpl] get; }
  }
}
