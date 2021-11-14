// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextConstantsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [ExclusiveTo(typeof (TextConstants))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2006875187, 6301, 19450, 151, 200, 16, 219, 19, 93, 151, 110)]
  [WebHostHidden]
  internal interface ITextConstantsStatics
  {
    Color AutoColor { get; }

    int MinUnitCount { get; }

    int MaxUnitCount { get; }

    Color UndefinedColor { get; }

    float UndefinedFloatValue { get; }

    int UndefinedInt32Value { get; }

    FontStretch UndefinedFontStretch { get; }

    FontStyle UndefinedFontStyle { get; }
  }
}
