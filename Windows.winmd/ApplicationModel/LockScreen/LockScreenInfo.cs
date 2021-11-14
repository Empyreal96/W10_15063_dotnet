// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.LockScreenInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.LockScreen
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LockScreenInfo : ILockScreenInfo
  {
    public extern event TypedEventHandler<LockScreenInfo, object> LockScreenImageChanged;

    public extern IRandomAccessStream LockScreenImage { [MethodImpl] get; }

    public extern event TypedEventHandler<LockScreenInfo, object> BadgesChanged;

    public extern IVectorView<LockScreenBadge> Badges { [MethodImpl] get; }

    public extern event TypedEventHandler<LockScreenInfo, object> DetailTextChanged;

    public extern IVectorView<string> DetailText { [MethodImpl] get; }

    public extern event TypedEventHandler<LockScreenInfo, object> AlarmIconChanged;

    public extern IRandomAccessStream AlarmIcon { [MethodImpl] get; }
  }
}
