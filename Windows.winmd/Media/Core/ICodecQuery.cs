// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ICodecQuery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CodecQuery))]
  [Guid(573216058, 44897, 19972, 128, 138, 164, 99, 78, 47, 58, 196)]
  internal interface ICodecQuery
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<CodecInfo>> FindAllAsync(
      CodecKind kind,
      CodecCategory category,
      string subType);
  }
}
