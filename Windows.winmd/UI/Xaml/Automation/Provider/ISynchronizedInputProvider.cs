// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ISynchronizedInputProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [Guid(1029754571, 55892, 19107, 185, 21, 227, 36, 68, 39, 212, 172)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISynchronizedInputProvider
  {
    void Cancel();

    void StartListening(SynchronizedInputType inputType);
  }
}
