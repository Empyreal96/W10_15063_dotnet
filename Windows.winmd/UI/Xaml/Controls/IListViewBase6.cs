// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase6
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4171507255, 38491, 18491, 148, 229, 229, 201, 254, 240, 227, 82)]
  [ExclusiveTo(typeof (ListViewBase))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IListViewBase6
  {
    [RemoteAsync]
    IAsyncOperation<bool> TryStartConnectedAnimationAsync(
      ConnectedAnimation animation,
      object item,
      string elementName);

    ConnectedAnimation PrepareConnectedAnimation(
      string key,
      object item,
      string elementName);
  }
}
