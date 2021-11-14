// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionNineGridBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class CompositionNineGridBrush : CompositionBrush, ICompositionNineGridBrush
  {
    public extern float BottomInset { [MethodImpl] get; [MethodImpl] set; }

    public extern float BottomInsetScale { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCenterHollow { [MethodImpl] get; [MethodImpl] set; }

    public extern float LeftInset { [MethodImpl] get; [MethodImpl] set; }

    public extern float LeftInsetScale { [MethodImpl] get; [MethodImpl] set; }

    public extern float RightInset { [MethodImpl] get; [MethodImpl] set; }

    public extern float RightInsetScale { [MethodImpl] get; [MethodImpl] set; }

    public extern CompositionBrush Source { [MethodImpl] get; [MethodImpl] set; }

    public extern float TopInset { [MethodImpl] get; [MethodImpl] set; }

    public extern float TopInsetScale { [MethodImpl] get; [MethodImpl] set; }

    [Overload("SetInsets")]
    [MethodImpl]
    public extern void SetInsets(float inset);

    [Overload("SetInsetsWithValues")]
    [MethodImpl]
    public extern void SetInsets(float left, float top, float right, float bottom);

    [Overload("SetInsetScales")]
    [MethodImpl]
    public extern void SetInsetScales(float scale);

    [Overload("SetInsetScalesWithValues")]
    [MethodImpl]
    public extern void SetInsetScales(float left, float top, float right, float bottom);
  }
}
