// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IXamlRenderingBackgroundTaskFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [Guid(2748431203, 14584, 19875, 159, 202, 253, 129, 40, 162, 203, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (XamlRenderingBackgroundTask))]
  [WebHostHidden]
  internal interface IXamlRenderingBackgroundTaskFactory
  {
    XamlRenderingBackgroundTask CreateInstance(
      object outer,
      out object inner);
  }
}
