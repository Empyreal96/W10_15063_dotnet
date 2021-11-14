// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.ILockScreenBadge
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.LockScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LockScreenBadge))]
  [Guid(3914401241, 11263, 19888, 155, 79, 56, 36, 119, 139, 156, 154)]
  internal interface ILockScreenBadge
  {
    IRandomAccessStream Logo { get; }

    IRandomAccessStream Glyph { get; }

    IReference<uint> Number { get; }

    string AutomationName { get; }

    void LaunchApp();
  }
}
