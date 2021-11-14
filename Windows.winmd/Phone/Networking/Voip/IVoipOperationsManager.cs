// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.IVoipOperationsManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(3128418876, 14553, 19963, 133, 63, 249, 1, 151, 143, 247, 250)]
  [ExclusiveTo(typeof (VoipCallCoordinator))]
  internal interface IVoipOperationsManager
  {
    IVoipOperation GetNextOperation();
  }
}
