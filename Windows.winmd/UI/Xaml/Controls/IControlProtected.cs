// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlProtected
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Control))]
  [Guid(395401338, 10876, 18817, 162, 216, 171, 153, 255, 252, 101, 185)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IControlProtected
  {
    object DefaultStyleKey { get; set; }

    DependencyObject GetTemplateChild(string childName);
  }
}
