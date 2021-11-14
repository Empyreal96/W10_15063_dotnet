// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VisualStateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class VisualStateChangedEventArgs : IVisualStateChangedEventArgs
  {
    [MethodImpl]
    public extern VisualStateChangedEventArgs();

    public extern VisualState OldState { [MethodImpl] get; [MethodImpl] set; }

    public extern VisualState NewState { [MethodImpl] get; [MethodImpl] set; }

    public extern Control Control { [MethodImpl] get; [MethodImpl] set; }
  }
}
