// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskBuilder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BackgroundTaskBuilder : 
    IBackgroundTaskBuilder,
    IBackgroundTaskBuilder2,
    IBackgroundTaskBuilder3,
    IBackgroundTaskBuilder4
  {
    [MethodImpl]
    public extern BackgroundTaskBuilder();

    public extern string TaskEntryPoint { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void SetTrigger(IBackgroundTrigger trigger);

    [MethodImpl]
    public extern void AddCondition(IBackgroundCondition condition);

    public extern string Name { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern BackgroundTaskRegistration Register();

    public extern bool CancelOnConditionLoss { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsNetworkRequested { [MethodImpl] set; [MethodImpl] get; }

    public extern BackgroundTaskRegistrationGroup TaskGroup { [MethodImpl] get; [MethodImpl] set; }
  }
}
