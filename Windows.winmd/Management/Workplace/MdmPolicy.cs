// Decompiled with JetBrains decompiler
// Type: Windows.Management.Workplace.MdmPolicy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Workplace
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMdmPolicyStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMdmAllowPolicyStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class MdmPolicy
  {
    [MethodImpl]
    public static extern MessagingSyncPolicy GetMessagingSyncPolicy();

    [MethodImpl]
    public static extern bool IsBrowserAllowed();

    [MethodImpl]
    public static extern bool IsCameraAllowed();

    [MethodImpl]
    public static extern bool IsMicrosoftAccountAllowed();

    [MethodImpl]
    public static extern bool IsStoreAllowed();
  }
}
