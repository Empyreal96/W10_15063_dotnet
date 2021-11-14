// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemKinds
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IRemoteSystemKindStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class RemoteSystemKinds
  {
    public static extern string Phone { [MethodImpl] get; }

    public static extern string Hub { [MethodImpl] get; }

    public static extern string Holographic { [MethodImpl] get; }

    public static extern string Desktop { [MethodImpl] get; }

    public static extern string Xbox { [MethodImpl] get; }
  }
}
