// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserDeviceAssociationChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (UserDeviceAssociationChangedEventArgs))]
  [Guid(3172953964, 47965, 19835, 165, 240, 200, 205, 17, 163, 141, 66)]
  internal interface IUserDeviceAssociationChangedEventArgs
  {
    string DeviceId { get; }

    User NewUser { get; }

    User OldUser { get; }
  }
}
