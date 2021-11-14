// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.FindNextElementOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class FindNextElementOptions : IFindNextElementOptions
  {
    [MethodImpl]
    public extern FindNextElementOptions();

    public extern DependencyObject SearchRoot { [MethodImpl] get; [MethodImpl] set; }

    public extern Rect ExclusionRect { [MethodImpl] get; [MethodImpl] set; }

    public extern Rect HintRect { [MethodImpl] get; [MethodImpl] set; }

    public extern XYFocusNavigationStrategyOverride XYFocusNavigationStrategyOverride { [MethodImpl] get; [MethodImpl] set; }
  }
}
