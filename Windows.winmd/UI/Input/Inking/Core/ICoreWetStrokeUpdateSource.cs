// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreWetStrokeUpdateSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreWetStrokeUpdateSource))]
  [Guid(527535650, 61010, 19968, 130, 9, 76, 62, 91, 33, 163, 204)]
  internal interface ICoreWetStrokeUpdateSource
  {
    event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeStarting;

    event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeContinuing;

    event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeStopping;

    event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeCompleted;

    event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeCanceled;

    InkPresenter InkPresenter { get; }
  }
}
