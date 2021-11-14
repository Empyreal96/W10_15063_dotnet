// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionNineGridBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4065416420, 48268, 19431, 184, 15, 134, 133, 184, 60, 1, 134)]
  [ExclusiveTo(typeof (CompositionNineGridBrush))]
  internal interface ICompositionNineGridBrush
  {
    float BottomInset { get; set; }

    float BottomInsetScale { get; set; }

    bool IsCenterHollow { get; set; }

    float LeftInset { get; set; }

    float LeftInsetScale { get; set; }

    float RightInset { get; set; }

    float RightInsetScale { get; set; }

    CompositionBrush Source { get; set; }

    float TopInset { get; set; }

    float TopInsetScale { get; set; }

    [Overload("SetInsets")]
    void SetInsets(float inset);

    [Overload("SetInsetsWithValues")]
    void SetInsets(float left, float top, float right, float bottom);

    [Overload("SetInsetScales")]
    void SetInsetScales(float scale);

    [Overload("SetInsetScalesWithValues")]
    void SetInsetScales(float left, float top, float right, float bottom);
  }
}
