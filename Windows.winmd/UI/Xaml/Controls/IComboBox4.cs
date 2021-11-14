// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBox4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ComboBox))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(3080146761, 45148, 18425, 154, 175, 214, 249, 24, 123, 229, 253)]
  internal interface IComboBox4
  {
    ComboBoxSelectionChangedTrigger SelectionChangedTrigger { get; set; }
  }
}
