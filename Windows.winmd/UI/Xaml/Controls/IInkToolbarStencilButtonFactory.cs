// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarStencilButtonFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkToolbarStencilButton))]
  [WebHostHidden]
  [Guid(2718368209, 35440, 19831, 137, 212, 23, 48, 163, 165, 142, 223)]
  internal interface IInkToolbarStencilButtonFactory
  {
    InkToolbarStencilButton CreateInstance(object outer, out object inner);
  }
}
