// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBoxOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ComboBox))]
  [Guid(1325491521, 48382, 18978, 137, 50, 201, 20, 152, 28, 34, 64)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IComboBoxOverrides
  {
    void OnDropDownClosed(object e);

    void OnDropDownOpened(object e);
  }
}
