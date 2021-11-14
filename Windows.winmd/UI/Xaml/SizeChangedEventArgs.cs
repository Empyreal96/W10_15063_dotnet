// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.SizeChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SizeChangedEventArgs : RoutedEventArgs, ISizeChangedEventArgs
  {
    public extern Size PreviousSize { [MethodImpl] get; }

    public extern Size NewSize { [MethodImpl] get; }
  }
}
