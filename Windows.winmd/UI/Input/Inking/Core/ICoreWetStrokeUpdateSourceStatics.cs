// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreWetStrokeUpdateSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(1034788026, 7485, 18094, 171, 157, 134, 71, 72, 108, 111, 144)]
  [ExclusiveTo(typeof (CoreWetStrokeUpdateSource))]
  internal interface ICoreWetStrokeUpdateSourceStatics
  {
    CoreWetStrokeUpdateSource Create(InkPresenter inkPresenter);
  }
}
