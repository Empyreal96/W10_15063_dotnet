// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBoxFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2886534212, 42587, 19133, 134, 223, 48, 22, 4, 158, 254, 220)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ComboBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IComboBoxFactory
  {
    ComboBox CreateInstance(object outer, out object inner);
  }
}
