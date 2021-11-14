// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemsControl))]
  [WebHostHidden]
  [Guid(1967927910, 1321, 17891, 135, 72, 191, 116, 125, 21, 131, 87)]
  internal interface IItemsControl2
  {
    Panel ItemsPanelRoot { get; }
  }
}
