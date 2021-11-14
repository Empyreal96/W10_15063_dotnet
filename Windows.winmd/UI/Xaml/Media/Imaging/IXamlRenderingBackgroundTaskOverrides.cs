// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IXamlRenderingBackgroundTaskOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ExclusiveTo(typeof (XamlRenderingBackgroundTask))]
  [Guid(2620025239, 43272, 18193, 180, 178, 169, 96, 219, 61, 142, 90)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IXamlRenderingBackgroundTaskOverrides
  {
    void OnRun(IBackgroundTaskInstance taskInstance);
  }
}
