// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ExceptionRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IExceptionRoutedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ExceptionRoutedEventArgs : RoutedEventArgs, IExceptionRoutedEventArgs
  {
    public extern string ErrorMessage { [MethodImpl] get; }
  }
}
