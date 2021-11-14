// Decompiled with JetBrains decompiler
// Type: Windows.System.KnownUserProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IKnownUserPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public static class KnownUserProperties
  {
    public static extern string DisplayName { [MethodImpl] get; }

    public static extern string FirstName { [MethodImpl] get; }

    public static extern string LastName { [MethodImpl] get; }

    public static extern string ProviderName { [MethodImpl] get; }

    public static extern string AccountName { [MethodImpl] get; }

    public static extern string GuestHost { [MethodImpl] get; }

    public static extern string PrincipalName { [MethodImpl] get; }

    public static extern string DomainName { [MethodImpl] get; }

    public static extern string SessionInitiationProtocolUri { [MethodImpl] get; }
  }
}
