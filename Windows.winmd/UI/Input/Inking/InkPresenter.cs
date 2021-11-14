// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkPresenter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  [DualApiPartition(version = 167772160)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InkPresenter : IInkPresenter, IInkPresenter2
  {
    public extern bool IsInputEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern CoreInputDeviceTypes InputDeviceTypes { [MethodImpl] get; [MethodImpl] set; }

    public extern InkUnprocessedInput UnprocessedInput { [MethodImpl] get; }

    public extern InkStrokeInput StrokeInput { [MethodImpl] get; }

    public extern InkInputProcessingConfiguration InputProcessingConfiguration { [MethodImpl] get; }

    public extern InkStrokeContainer StrokeContainer { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern InkDrawingAttributes CopyDefaultDrawingAttributes();

    [MethodImpl]
    public extern void UpdateDefaultDrawingAttributes(InkDrawingAttributes value);

    [MethodImpl]
    public extern InkSynchronizer ActivateCustomDrying();

    [MethodImpl]
    public extern void SetPredefinedConfiguration(InkPresenterPredefinedConfiguration value);

    public extern event TypedEventHandler<InkPresenter, InkStrokesCollectedEventArgs> StrokesCollected;

    public extern event TypedEventHandler<InkPresenter, InkStrokesErasedEventArgs> StrokesErased;

    public extern InkHighContrastAdjustment HighContrastAdjustment { [MethodImpl] get; [MethodImpl] set; }
  }
}
