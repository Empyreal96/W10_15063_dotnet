// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionCommitBatch
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (CompositionCommitBatch))]
  [Guid(218159824, 51719, 17408, 140, 142, 203, 93, 176, 133, 89, 204)]
  [WebHostHidden]
  internal interface ICompositionCommitBatch
  {
    bool IsActive { get; }

    bool IsEnded { get; }

    event TypedEventHandler<object, CompositionBatchCompletedEventArgs> Completed;
  }
}
