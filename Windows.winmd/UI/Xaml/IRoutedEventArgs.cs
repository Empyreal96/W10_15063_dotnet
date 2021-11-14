// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(1553488582, 55298, 19256, 162, 35, 191, 7, 12, 67, 254, 223)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRoutedEventArgs
  {
    object OriginalSource { get; }
  }
}
