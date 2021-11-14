// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMseSourceBufferList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2516248807, 43239, 20159, 137, 39, 20, 94, 148, 11, 165, 17)]
  [ExclusiveTo(typeof (MseSourceBufferList))]
  internal interface IMseSourceBufferList
  {
    event TypedEventHandler<MseSourceBufferList, object> SourceBufferAdded;

    event TypedEventHandler<MseSourceBufferList, object> SourceBufferRemoved;

    IVectorView<MseSourceBuffer> Buffers { get; }
  }
}
