// Decompiled with JetBrains decompiler
// Type: Windows.System.UserDeviceAssociationChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDeviceAssociationChangedEventArgs : IUserDeviceAssociationChangedEventArgs
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern User NewUser { [MethodImpl] get; }

    public extern User OldUser { [MethodImpl] get; }
  }
}
