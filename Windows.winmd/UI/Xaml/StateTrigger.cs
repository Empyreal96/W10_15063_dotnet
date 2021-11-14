// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.StateTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStateTriggerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StateTrigger : StateTriggerBase, IStateTrigger
  {
    [MethodImpl]
    public extern StateTrigger();

    public extern bool IsActive { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IsActiveProperty { [MethodImpl] get; }
  }
}
