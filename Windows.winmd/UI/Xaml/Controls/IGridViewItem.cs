// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridViewItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2107179505, 59329, 20099, 180, 112, 201, 214, 215, 189, 169, 245)]
  [ExclusiveTo(typeof (GridViewItem))]
  [WebHostHidden]
  internal interface IGridViewItem
  {
    GridViewItemTemplateSettings TemplateSettings { get; }
  }
}
