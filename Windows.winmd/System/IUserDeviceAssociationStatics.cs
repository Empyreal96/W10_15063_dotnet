// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserDeviceAssociationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(2118721044, 63578, 19463, 141, 169, 127, 227, 208, 84, 35, 67)]
  [ExclusiveTo(typeof (UserDeviceAssociation))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserDeviceAssociationStatics
  {
    User FindUserFromDeviceId(string deviceId);

    event EventHandler<UserDeviceAssociationChangedEventArgs> UserDeviceAssociationChanged;
  }
}
