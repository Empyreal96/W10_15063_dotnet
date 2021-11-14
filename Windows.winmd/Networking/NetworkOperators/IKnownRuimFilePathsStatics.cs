// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IKnownRuimFilePathsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(948160697, 65316, 17777, 168, 103, 9, 249, 96, 66, 110, 20)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KnownRuimFilePaths))]
  internal interface IKnownRuimFilePathsStatics
  {
    IVectorView<uint> EFSpn { get; }

    IVectorView<uint> Gid1 { get; }

    IVectorView<uint> Gid2 { get; }
  }
}
