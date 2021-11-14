// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.IFontWeightsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FontWeights))]
  [Guid(3015014869, 7081, 18667, 157, 173, 192, 149, 232, 194, 59, 163)]
  [WebHostHidden]
  internal interface IFontWeightsStatics
  {
    FontWeight Black { get; }

    FontWeight Bold { get; }

    FontWeight ExtraBlack { get; }

    FontWeight ExtraBold { get; }

    FontWeight ExtraLight { get; }

    FontWeight Light { get; }

    FontWeight Medium { get; }

    FontWeight Normal { get; }

    FontWeight SemiBold { get; }

    FontWeight SemiLight { get; }

    FontWeight Thin { get; }
  }
}
