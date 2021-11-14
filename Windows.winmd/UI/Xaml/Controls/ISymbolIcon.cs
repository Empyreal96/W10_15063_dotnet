// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISymbolIcon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SymbolIcon))]
  [Guid(2051503305, 42659, 19248, 143, 241, 144, 129, 215, 14, 154, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISymbolIcon
  {
    Symbol Symbol { get; set; }
  }
}
