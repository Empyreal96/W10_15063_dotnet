// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IBlock
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [Guid(1271791638, 56647, 17232, 140, 176, 225, 113, 96, 10, 200, 150)]
  [ExclusiveTo(typeof (Block))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBlock
  {
    TextAlignment TextAlignment { get; set; }

    double LineHeight { get; set; }

    LineStackingStrategy LineStackingStrategy { get; set; }

    Thickness Margin { get; set; }
  }
}
