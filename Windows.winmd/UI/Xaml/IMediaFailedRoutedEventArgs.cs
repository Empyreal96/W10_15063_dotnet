// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IMediaFailedRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (MediaFailedRoutedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1188166285, 20809, 16723, 186, 60, 176, 62, 100, 238, 83, 30)]
  internal interface IMediaFailedRoutedEventArgs
  {
    string ErrorTrace { get; }
  }
}
