// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.ILockScreenInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.LockScreen
{
  [ExclusiveTo(typeof (LockScreenInfo))]
  [Guid(4120553052, 38673, 19913, 166, 48, 149, 182, 203, 140, 218, 208)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILockScreenInfo
  {
    event TypedEventHandler<LockScreenInfo, object> LockScreenImageChanged;

    IRandomAccessStream LockScreenImage { get; }

    event TypedEventHandler<LockScreenInfo, object> BadgesChanged;

    IVectorView<LockScreenBadge> Badges { get; }

    event TypedEventHandler<LockScreenInfo, object> DetailTextChanged;

    IVectorView<string> DetailText { get; }

    event TypedEventHandler<LockScreenInfo, object> AlarmIconChanged;

    IRandomAccessStream AlarmIcon { get; }
  }
}
