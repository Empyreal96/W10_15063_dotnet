// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.FirstSignInSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IFirstSignInSettingsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class FirstSignInSettings : 
    IFirstSignInSettings,
    IMapView<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
    [MethodImpl]
    public extern object Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern void Split(
      out IMapView<string, object> first,
      out IMapView<string, object> second);

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, object>> First();

    [MethodImpl]
    public static extern FirstSignInSettings GetDefault();
  }
}
