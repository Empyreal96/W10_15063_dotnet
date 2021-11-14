// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ManipulationStartingRoutedEventArgs : 
    RoutedEventArgs,
    IManipulationStartingRoutedEventArgs
  {
    [MethodImpl]
    public extern ManipulationStartingRoutedEventArgs();

    public extern ManipulationModes Mode { [MethodImpl] get; [MethodImpl] set; }

    public extern UIElement Container { [MethodImpl] get; [MethodImpl] set; }

    public extern ManipulationPivot Pivot { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
