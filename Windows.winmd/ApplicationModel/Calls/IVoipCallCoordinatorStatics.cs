// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IVoipCallCoordinatorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (VoipCallCoordinator))]
  [WebHostHidden]
  [Guid(2136809259, 57418, 19728, 179, 26, 165, 92, 146, 44, 194, 251)]
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  internal interface IVoipCallCoordinatorStatics
  {
    VoipCallCoordinator GetDefault();
  }
}
