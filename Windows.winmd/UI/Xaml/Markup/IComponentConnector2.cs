// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IComponentConnector2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3700373131, 60620, 18830, 177, 57, 145, 20, 34, 84, 215, 174)]
  [WebHostHidden]
  public interface IComponentConnector2
  {
    IComponentConnector GetBindingConnector(int connectionId, object target);
  }
}
