// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IGridViewItemPresenterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(1405165944, 25531, 19045, 163, 241, 171, 17, 76, 252, 111, 254)]
  [ExclusiveTo(typeof (GridViewItemPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGridViewItemPresenterFactory
  {
    GridViewItemPresenter CreateInstance(object outer, out object inner);
  }
}
