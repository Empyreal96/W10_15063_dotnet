// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlock4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2954162800, 38920, 19164, 180, 82, 96, 205, 165, 65, 0, 193)]
  [ExclusiveTo(typeof (TextBlock))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ITextBlock4
  {
    CompositionBrush GetAlphaMask();
  }
}
