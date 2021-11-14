// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.ISystemIdentificationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [Guid(1434580010, 54239, 19859, 163, 125, 196, 26, 97, 108, 109, 1)]
  [ExclusiveTo(typeof (SystemIdentification))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ISystemIdentificationStatics
  {
    SystemIdentificationInfo GetSystemIdForPublisher();

    SystemIdentificationInfo GetSystemIdForUser(User user);
  }
}
