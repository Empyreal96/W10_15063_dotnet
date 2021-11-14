// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Static(typeof (ICoreWetStrokeUpdateSourceStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class CoreWetStrokeUpdateSource : ICoreWetStrokeUpdateSource
  {
    public extern event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeStarting;

    public extern event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeContinuing;

    public extern event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeStopping;

    public extern event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeCompleted;

    public extern event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeCanceled;

    public extern InkPresenter InkPresenter { [MethodImpl] get; }

    [MethodImpl]
    public static extern CoreWetStrokeUpdateSource Create(
      InkPresenter inkPresenter);
  }
}
