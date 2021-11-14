// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneLineConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Guid(4263925858, 63055, 17170, 178, 168, 78, 37, 119, 33, 170, 149)]
  [ExclusiveTo(typeof (PhoneLineConfiguration))]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  internal interface IPhoneLineConfiguration
  {
    bool IsVideoCallingEnabled { get; }

    IMapView<string, object> ExtendedProperties { get; }
  }
}
