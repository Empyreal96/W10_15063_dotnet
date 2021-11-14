// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IConnectTileData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ExclusiveTo(typeof (ConnectTileData))]
  [Guid(3257848977, 21737, 17979, 153, 219, 90, 133, 99, 33, 8, 193)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IConnectTileData
  {
    string Title { get; set; }

    IVector<ConnectTileImage> Images { get; }
  }
}
