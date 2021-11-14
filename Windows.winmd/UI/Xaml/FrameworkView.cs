// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FrameworkView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class FrameworkView : IFrameworkView, global::Windows.ApplicationModel.Core.IFrameworkView
  {
    [MethodImpl]
    public extern FrameworkView();

    [MethodImpl]
    public extern void Initialize(CoreApplicationView applicationView);

    [MethodImpl]
    public extern void SetWindow(CoreWindow window);

    [MethodImpl]
    public extern void Load(string entryPoint);

    [MethodImpl]
    public extern void Run();

    [MethodImpl]
    public extern void Uninitialize();
  }
}
