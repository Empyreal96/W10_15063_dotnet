// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IUIElementCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3596627284, 35062, 17398, 133, 216, 169, 217, 20, 166, 221, 59)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UIElementCollection))]
  internal interface IUIElementCollection
  {
    void Move(uint oldIndex, uint newIndex);
  }
}
