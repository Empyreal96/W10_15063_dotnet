// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.ICortanaPermissionsManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Cortana
{
  [Guid(1991370362, 45125, 17428, 157, 109, 42, 211, 165, 254, 58, 126)]
  [ExclusiveTo(typeof (CortanaPermissionsManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ICortanaPermissionsManagerStatics
  {
    CortanaPermissionsManager GetDefault();
  }
}
