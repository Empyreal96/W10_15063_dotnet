// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IDropTargetProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2049203165, 46168, 20448, 152, 200, 170, 200, 157, 245, 109, 97)]
  public interface IDropTargetProvider
  {
    string DropEffect { get; }

    string[] DropEffects { get; }
  }
}
