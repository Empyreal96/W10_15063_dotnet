// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TextConstants
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (ITextConstantsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class TextConstants
  {
    public static extern Color AutoColor { [MethodImpl] get; }

    public static extern int MinUnitCount { [MethodImpl] get; }

    public static extern int MaxUnitCount { [MethodImpl] get; }

    public static extern Color UndefinedColor { [MethodImpl] get; }

    public static extern float UndefinedFloatValue { [MethodImpl] get; }

    public static extern int UndefinedInt32Value { [MethodImpl] get; }

    public static extern FontStretch UndefinedFontStretch { [MethodImpl] get; }

    public static extern FontStyle UndefinedFontStyle { [MethodImpl] get; }
  }
}
