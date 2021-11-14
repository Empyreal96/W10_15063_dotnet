// Decompiled with JetBrains decompiler
// Type: Windows.UI.ColorHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IColorHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IColorHelperStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ColorHelper : IColorHelper
  {
    [MethodImpl]
    public static extern string ToDisplayName(Color color);

    [MethodImpl]
    public static extern Color FromArgb(byte a, byte r, byte g, byte b);
  }
}
