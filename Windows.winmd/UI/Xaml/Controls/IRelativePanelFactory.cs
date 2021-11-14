// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRelativePanelFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RelativePanel))]
  [Guid(2220890428, 13851, 17594, 161, 126, 184, 76, 157, 205, 199, 114)]
  internal interface IRelativePanelFactory
  {
    RelativePanel CreateInstance(object outer, out object inner);
  }
}
