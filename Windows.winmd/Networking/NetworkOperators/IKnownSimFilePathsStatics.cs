// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IKnownSimFilePathsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(2160925283, 14245, 17363, 128, 163, 204, 210, 62, 143, 236, 238)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KnownSimFilePaths))]
  internal interface IKnownSimFilePathsStatics
  {
    IVectorView<uint> EFOns { get; }

    IVectorView<uint> EFSpn { get; }

    IVectorView<uint> Gid1 { get; }

    IVectorView<uint> Gid2 { get; }
  }
}
