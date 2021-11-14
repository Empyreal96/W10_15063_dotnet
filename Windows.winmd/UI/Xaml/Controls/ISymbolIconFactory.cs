// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISymbolIconFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SymbolIcon))]
  [Guid(3341101960, 59244, 19268, 138, 5, 4, 107, 157, 199, 114, 184)]
  internal interface ISymbolIconFactory
  {
    SymbolIcon CreateInstanceWithSymbol(Symbol symbol);
  }
}
