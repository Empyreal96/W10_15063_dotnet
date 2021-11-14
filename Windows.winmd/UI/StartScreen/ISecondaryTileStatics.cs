// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ExclusiveTo(typeof (SecondaryTile))]
  [Guid(2576387502, 53329, 18038, 135, 254, 158, 194, 66, 216, 60, 116)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISecondaryTileStatics
  {
    bool Exists(string tileId);

    [RemoteAsync]
    [Overload("FindAllAsync")]
    IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync();

    [Overload("FindAllForApplicationAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync(
      string applicationId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<SecondaryTile>> FindAllForPackageAsync();
  }
}
