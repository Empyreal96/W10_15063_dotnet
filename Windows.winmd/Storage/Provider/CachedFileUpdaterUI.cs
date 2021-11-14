// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.CachedFileUpdaterUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CachedFileUpdaterUI : ICachedFileUpdaterUI, ICachedFileUpdaterUI2
  {
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern CachedFileTarget UpdateTarget { [MethodImpl] get; }

    public extern event TypedEventHandler<CachedFileUpdaterUI, FileUpdateRequestedEventArgs> FileUpdateRequested;

    public extern event TypedEventHandler<CachedFileUpdaterUI, object> UIRequested;

    public extern UIStatus UIStatus { [MethodImpl] get; }

    public extern FileUpdateRequest UpdateRequest { [MethodImpl] get; }

    [MethodImpl]
    public extern FileUpdateRequestDeferral GetDeferral();
  }
}
