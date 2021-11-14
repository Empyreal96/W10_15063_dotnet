// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (IXamlRenderingBackgroundTaskFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  public class XamlRenderingBackgroundTask : 
    IXamlRenderingBackgroundTask,
    IXamlRenderingBackgroundTaskOverrides
  {
    [MethodImpl]
    protected extern XamlRenderingBackgroundTask();

    [MethodImpl]
    extern void IXamlRenderingBackgroundTaskOverrides.OnRun(
      IBackgroundTaskInstance taskInstance);
  }
}
