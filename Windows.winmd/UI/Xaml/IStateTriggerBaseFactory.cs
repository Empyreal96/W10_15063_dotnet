// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IStateTriggerBaseFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (StateTriggerBase))]
  [Guid(2534288459, 49071, 18352, 190, 66, 193, 215, 17, 187, 46, 159)]
  internal interface IStateTriggerBaseFactory
  {
    StateTriggerBase CreateInstance(object outer, out object inner);
  }
}
