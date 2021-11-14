// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IRetailInfoStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [Guid(118671032, 35730, 20266, 132, 153, 3, 31, 23, 152, 214, 239)]
  [ExclusiveTo(typeof (RetailInfo))]
  [ContractVersion(typeof (ProfileRetailInfoContract), 65536)]
  internal interface IRetailInfoStatics
  {
    bool IsDemoModeEnabled { get; }

    IMapView<string, object> Properties { [return: HasVariant] get; }
  }
}
