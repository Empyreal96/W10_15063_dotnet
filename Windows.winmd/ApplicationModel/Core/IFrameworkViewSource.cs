// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IFrameworkViewSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3447129620, 26052, 17004, 148, 148, 52, 252, 67, 85, 72, 98)]
  [WebHostHidden]
  public interface IFrameworkViewSource
  {
    IFrameworkView CreateView();
  }
}
