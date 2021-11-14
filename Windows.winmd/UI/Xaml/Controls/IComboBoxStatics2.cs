// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBoxStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ComboBox))]
  [WebHostHidden]
  [Guid(2476247569, 16428, 19219, 150, 209, 114, 32, 38, 107, 146, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IComboBoxStatics2
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty PlaceholderTextProperty { get; }
  }
}
