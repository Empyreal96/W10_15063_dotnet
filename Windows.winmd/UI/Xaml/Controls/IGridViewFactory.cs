// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridViewFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3653028489, 2553, 19566, 168, 62, 241, 153, 20, 111, 14, 125)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GridView))]
  internal interface IGridViewFactory
  {
    GridView CreateInstance(object outer, out object inner);
  }
}
