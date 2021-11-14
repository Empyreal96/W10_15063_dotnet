// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IKnownCSimFilePathsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KnownCSimFilePaths))]
  [Guid(3025710829, 18929, 19490, 176, 115, 150, 213, 17, 191, 156, 53)]
  internal interface IKnownCSimFilePathsStatics
  {
    IVectorView<uint> EFSpn { get; }

    IVectorView<uint> Gid1 { get; }

    IVectorView<uint> Gid2 { get; }
  }
}
