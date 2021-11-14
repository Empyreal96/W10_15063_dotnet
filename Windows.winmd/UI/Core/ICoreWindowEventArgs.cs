// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindowEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(657137395, 50739, 19877, 162, 108, 198, 208, 245, 107, 41, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface ICoreWindowEventArgs
  {
    bool Handled { get; set; }
  }
}
