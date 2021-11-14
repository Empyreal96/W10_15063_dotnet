// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPickerFlyoutBaseFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2126674515, 38146, 19435, 179, 66, 0, 86, 108, 143, 22, 176)]
  [ExclusiveTo(typeof (PickerFlyoutBase))]
  [WebHostHidden]
  internal interface IPickerFlyoutBaseFactory
  {
    PickerFlyoutBase CreateInstance(object outer, out object inner);
  }
}
