// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ConnectTileData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Phone.PhoneInternalContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class ConnectTileData : IConnectTileData
  {
    [MethodImpl]
    public extern ConnectTileData();

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<ConnectTileImage> Images { [MethodImpl] get; }
  }
}
