// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3206649257, 62698, 17206, 151, 124, 248, 252, 247, 139, 13, 158)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INavigate
  {
    bool Navigate(TypeName sourcePageType);
  }
}
