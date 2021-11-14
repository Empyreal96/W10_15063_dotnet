// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyLicenseIterator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadyLicenseIterator : IIterator<IPlayReadyLicense>
  {
    public extern IPlayReadyLicense Current { [MethodImpl] get; }

    public extern bool HasCurrent { [MethodImpl] get; }

    [MethodImpl]
    public extern bool MoveNext();

    [MethodImpl]
    public extern uint GetMany([Out] IPlayReadyLicense[] items);
  }
}
