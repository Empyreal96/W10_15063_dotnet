// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IChoosingItemContainerEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ChoosingItemContainerEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2612280270, 44647, 19072, 131, 99, 227, 254, 27, 36, 79, 44)]
  [WebHostHidden]
  internal interface IChoosingItemContainerEventArgs
  {
    int ItemIndex { get; }

    object Item { get; }

    SelectorItem ItemContainer { get; set; }

    bool IsContainerPrepared { get; set; }
  }
}
