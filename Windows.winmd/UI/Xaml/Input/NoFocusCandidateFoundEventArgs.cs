// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.NoFocusCandidateFoundEventArgs
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
  [Threading(ThreadingModel.Both)]
  public sealed class NoFocusCandidateFoundEventArgs : 
    RoutedEventArgs,
    INoFocusCandidateFoundEventArgs
  {
    public extern FocusNavigationDirection Direction { [MethodImpl] get; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    public extern FocusInputDeviceKind InputDevice { [MethodImpl] get; }
  }
}
