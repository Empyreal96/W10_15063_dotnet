// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemContainerMapping
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1405743674, 62045, 17514, 153, 184, 199, 174, 184, 57, 5, 15)]
  public interface IItemContainerMapping
  {
    object ItemFromContainer(DependencyObject container);

    DependencyObject ContainerFromItem(object item);

    int IndexFromContainer(DependencyObject container);

    DependencyObject ContainerFromIndex(int index);
  }
}
