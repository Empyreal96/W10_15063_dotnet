// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.LocalContentSuggestionSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Search
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class LocalContentSuggestionSettings : ILocalContentSuggestionSettings
  {
    [MethodImpl]
    public extern LocalContentSuggestionSettings();

    public extern bool Enabled { [MethodImpl] set; [MethodImpl] get; }

    public extern IVector<StorageFolder> Locations { [MethodImpl] get; }

    public extern string AqsFilter { [MethodImpl] set; [MethodImpl] get; }

    public extern IVector<string> PropertiesToMatch { [MethodImpl] get; }
  }
}
