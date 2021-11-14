// Decompiled with JetBrains decompiler
// Type: Windows.System.UserDeviceAssociation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [Static(typeof (IUserDeviceAssociationStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class UserDeviceAssociation
  {
    [MethodImpl]
    public static extern User FindUserFromDeviceId(string deviceId);

    public static extern event EventHandler<UserDeviceAssociationChangedEventArgs> UserDeviceAssociationChanged;
  }
}
