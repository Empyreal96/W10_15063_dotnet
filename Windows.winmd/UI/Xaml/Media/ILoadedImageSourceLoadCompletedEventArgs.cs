// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILoadedImageSourceLoadCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (LoadedImageSourceLoadCompletedEventArgs))]
  [Guid(449186590, 30775, 17545, 179, 229, 208, 213, 173, 10, 86, 196)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  internal interface ILoadedImageSourceLoadCompletedEventArgs
  {
    LoadedImageSourceLoadStatus Status { get; }
  }
}
