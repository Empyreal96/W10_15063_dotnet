// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.ICustomMapTileDataSourceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3360127303, 51541, 20258, 148, 68, 161, 216, 215, 68, 175, 17)]
  [ExclusiveTo(typeof (CustomMapTileDataSource))]
  internal interface ICustomMapTileDataSourceFactory
  {
    CustomMapTileDataSource CreateInstance(object outer, out object inner);
  }
}
