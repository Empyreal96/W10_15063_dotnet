// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.IVoipCallCoordinatorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [ExclusiveTo(typeof (VoipCallCoordinator))]
  [Guid(284906939, 57469, 16510, 188, 57, 247, 204, 54, 65, 217, 121)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IVoipCallCoordinatorStatics
  {
    VoipCallCoordinator GetDefault();
  }
}
