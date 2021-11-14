// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICorePointerRedirector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [Guid(2409434260, 22152, 19212, 169, 241, 249, 49, 247, 250, 61, 195)]
  public interface ICorePointerRedirector
  {
    event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedAway;

    event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedTo;

    event TypedEventHandler<ICorePointerRedirector, PointerEventArgs> PointerRoutedReleased;
  }
}
