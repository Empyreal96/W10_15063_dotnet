// Decompiled with JetBrains decompiler
// Type: Windows.Management.Core.IApplicationDataManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Management.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(504914659, 27022, 18849, 151, 82, 222, 233, 73, 37, 185, 179)]
  [ExclusiveTo(typeof (ApplicationDataManager))]
  internal interface IApplicationDataManagerStatics
  {
    ApplicationData CreateForPackageFamily(string packageFamilyName);
  }
}
