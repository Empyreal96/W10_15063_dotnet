// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.RatedContentDescription
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.ContentRestrictions
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IRatedContentDescriptionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class RatedContentDescription : IRatedContentDescription
  {
    [MethodImpl]
    public extern RatedContentDescription(string id, string title, RatedContentCategory category);

    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Image { [MethodImpl] get; [MethodImpl] set; }

    public extern RatedContentCategory Category { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> Ratings { [MethodImpl] get; [MethodImpl] set; }
  }
}
