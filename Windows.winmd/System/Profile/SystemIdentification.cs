// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.SystemIdentification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [Static(typeof (ISystemIdentificationStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class SystemIdentification
  {
    [MethodImpl]
    public static extern SystemIdentificationInfo GetSystemIdForPublisher();

    [MethodImpl]
    public static extern SystemIdentificationInfo GetSystemIdForUser(
      User user);
  }
}
