// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IObjectModelProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [Guid(3284809401, 1939, 20176, 187, 244, 159, 244, 224, 249, 143, 128)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IObjectModelProvider
  {
    object GetUnderlyingObjectModel();
  }
}
