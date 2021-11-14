// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionScopedBatch
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionScopedBatch))]
  [WebHostHidden]
  [Guid(218159824, 64263, 18173, 140, 114, 98, 128, 209, 163, 209, 221)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICompositionScopedBatch
  {
    bool IsActive { get; }

    bool IsEnded { get; }

    void End();

    void Resume();

    void Suspend();

    event TypedEventHandler<object, CompositionBatchCompletedEventArgs> Completed;
  }
}
