// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ITickBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2571535354, 61942, 18557, 165, 172, 193, 89, 33, 191, 169, 149)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TickBar))]
  internal interface ITickBar
  {
    Brush Fill { get; set; }
  }
}
