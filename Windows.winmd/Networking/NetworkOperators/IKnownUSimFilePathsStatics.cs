// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IKnownUSimFilePathsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KnownUSimFilePaths))]
  [Guid(2083841409, 7963, 17396, 149, 48, 139, 9, 45, 50, 215, 31)]
  internal interface IKnownUSimFilePathsStatics
  {
    IVectorView<uint> EFSpn { get; }

    IVectorView<uint> EFOpl { get; }

    IVectorView<uint> EFPnn { get; }

    IVectorView<uint> Gid1 { get; }

    IVectorView<uint> Gid2 { get; }
  }
}
