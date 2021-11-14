// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.CachedFileUpdaterTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;

namespace Windows.ApplicationModel.Background
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CachedFileUpdaterTriggerDetails : ICachedFileUpdaterTriggerDetails
  {
    public extern CachedFileTarget UpdateTarget { [MethodImpl] get; }

    public extern FileUpdateRequest UpdateRequest { [MethodImpl] get; }

    public extern bool CanRequestUserInput { [MethodImpl] get; }
  }
}
