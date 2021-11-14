// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2972392794, 25625, 19990, 178, 18, 164, 83, 54, 183, 87, 120)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Control))]
  internal interface IControlFactory
  {
    Control CreateInstance(object outer, out object inner);
  }
}
