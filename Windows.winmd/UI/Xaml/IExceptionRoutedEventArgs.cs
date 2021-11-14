// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IExceptionRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3718246762, 19298, 19052, 164, 157, 6, 113, 239, 97, 54, 190)]
  [ExclusiveTo(typeof (ExceptionRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IExceptionRoutedEventArgs
  {
    string ErrorMessage { get; }
  }
}
