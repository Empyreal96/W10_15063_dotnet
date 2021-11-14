// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IEventTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3740858453, 2889, 16519, 177, 169, 184, 179, 132, 136, 247, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EventTrigger))]
  [WebHostHidden]
  internal interface IEventTrigger
  {
    RoutedEvent RoutedEvent { get; set; }

    TriggerActionCollection Actions { get; }
  }
}
