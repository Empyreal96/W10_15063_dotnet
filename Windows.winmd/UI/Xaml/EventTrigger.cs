// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.EventTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContentProperty(Name = "Actions")]
  [Threading(ThreadingModel.Both)]
  public sealed class EventTrigger : TriggerBase, IEventTrigger
  {
    [MethodImpl]
    public extern EventTrigger();

    public extern RoutedEvent RoutedEvent { [MethodImpl] get; [MethodImpl] set; }

    public extern TriggerActionCollection Actions { [MethodImpl] get; }
  }
}
