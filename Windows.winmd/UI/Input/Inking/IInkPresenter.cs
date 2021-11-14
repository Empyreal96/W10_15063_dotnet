// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkPresenter))]
  [WebHostHidden]
  [Guid(2795204834, 34939, 17807, 177, 115, 79, 228, 67, 137, 48, 163)]
  internal interface IInkPresenter
  {
    bool IsInputEnabled { get; set; }

    CoreInputDeviceTypes InputDeviceTypes { get; set; }

    InkUnprocessedInput UnprocessedInput { get; }

    InkStrokeInput StrokeInput { get; }

    InkInputProcessingConfiguration InputProcessingConfiguration { get; }

    InkStrokeContainer StrokeContainer { get; set; }

    InkDrawingAttributes CopyDefaultDrawingAttributes();

    void UpdateDefaultDrawingAttributes(InkDrawingAttributes value);

    InkSynchronizer ActivateCustomDrying();

    void SetPredefinedConfiguration(InkPresenterPredefinedConfiguration value);

    event TypedEventHandler<InkPresenter, InkStrokesCollectedEventArgs> StrokesCollected;

    event TypedEventHandler<InkPresenter, InkStrokesErasedEventArgs> StrokesErased;
  }
}
