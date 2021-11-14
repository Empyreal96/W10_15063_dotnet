// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateManagerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(2246416637, 42357, 18358, 158, 48, 56, 60, 208, 133, 133, 242)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VisualStateManager))]
  internal interface IVisualStateManagerFactory
  {
    VisualStateManager CreateInstance(object outer, out object inner);
  }
}
