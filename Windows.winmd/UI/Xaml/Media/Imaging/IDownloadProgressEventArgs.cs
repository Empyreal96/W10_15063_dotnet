// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IDownloadProgressEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [Guid(1930551508, 65172, 20080, 155, 144, 205, 212, 122, 194, 58, 251)]
  [ExclusiveTo(typeof (DownloadProgressEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IDownloadProgressEventArgs
  {
    int Progress { get; set; }
  }
}
