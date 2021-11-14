// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IAdaptiveTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(3378959490, 23275, 18497, 146, 71, 193, 160, 189, 214, 245, 159)]
  [ExclusiveTo(typeof (AdaptiveTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdaptiveTriggerFactory
  {
    AdaptiveTrigger CreateInstance(object outer, out object inner);
  }
}
