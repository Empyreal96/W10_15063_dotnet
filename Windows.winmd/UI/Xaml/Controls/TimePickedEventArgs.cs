// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TimePickedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class TimePickedEventArgs : DependencyObject, ITimePickedEventArgs
  {
    [MethodImpl]
    public extern TimePickedEventArgs();

    public extern TimeSpan OldTime { [MethodImpl] get; }

    public extern TimeSpan NewTime { [MethodImpl] get; }
  }
}
