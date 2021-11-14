// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDispatcherTimerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DispatcherTimer))]
  [Guid(3918929518, 13862, 16442, 175, 224, 4, 13, 88, 22, 86, 50)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDispatcherTimerFactory
  {
    DispatcherTimer CreateInstance(object outer, out object inner);
  }
}
