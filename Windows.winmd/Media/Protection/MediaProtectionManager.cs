// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.MediaProtectionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [Threading(ThreadingModel.MTA)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaProtectionManager : IMediaProtectionManager
  {
    [MethodImpl]
    public extern MediaProtectionManager();

    public extern event ServiceRequestedEventHandler ServiceRequested;

    public extern event RebootNeededEventHandler RebootNeeded;

    public extern event ComponentLoadFailedEventHandler ComponentLoadFailed;

    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
