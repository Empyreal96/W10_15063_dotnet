// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVirtualizingPanelProtected
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3385436994, 49714, 18333, 167, 201, 94, 118, 17, 25, 106, 69)]
  [ExclusiveTo(typeof (VirtualizingPanel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IVirtualizingPanelProtected
  {
    void AddInternalChild(UIElement child);

    void InsertInternalChild(int index, UIElement child);

    void RemoveInternalChildRange(int index, int range);
  }
}
