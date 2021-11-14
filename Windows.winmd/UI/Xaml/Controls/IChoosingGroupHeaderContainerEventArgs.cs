// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IChoosingGroupHeaderContainerEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChoosingGroupHeaderContainerEventArgs))]
  [WebHostHidden]
  [Guid(1742423254, 53761, 19826, 190, 172, 94, 142, 88, 175, 216, 199)]
  internal interface IChoosingGroupHeaderContainerEventArgs
  {
    ListViewBaseHeaderItem GroupHeaderContainer { get; set; }

    int GroupIndex { get; }

    object Group { get; }
  }
}
