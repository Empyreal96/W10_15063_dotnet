// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITextRangeProvider2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3552460283, 40788, 17986, 167, 165, 92, 24, 213, 238, 42, 63)]
  [WebHostHidden]
  public interface ITextRangeProvider2 : ITextRangeProvider
  {
    void ShowContextMenu();
  }
}
