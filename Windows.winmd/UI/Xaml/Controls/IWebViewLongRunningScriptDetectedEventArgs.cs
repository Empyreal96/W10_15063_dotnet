// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewLongRunningScriptDetectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WebViewLongRunningScriptDetectedEventArgs))]
  [Guid(4092600491, 42092, 17072, 158, 254, 105, 118, 77, 92, 255, 166)]
  internal interface IWebViewLongRunningScriptDetectedEventArgs
  {
    TimeSpan ExecutionTime { get; }

    bool StopPageScriptExecution { get; set; }
  }
}
