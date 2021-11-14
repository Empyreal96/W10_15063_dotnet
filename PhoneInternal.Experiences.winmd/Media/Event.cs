// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.Event
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  public sealed class Event : IMediaItem, IEvent
  {
    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetExtraProperties(IIterable<IKeyValuePair<string, object>> props);

    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> GetExtraPropertiesAsync(
      IIterable<string> propNames);

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern uint LegacyId { [MethodImpl] get; }

    public extern string PictureAlbumId { [MethodImpl] get; }

    public extern DateTime DateStart { [MethodImpl] get; }

    public extern uint Count { [MethodImpl] get; }

    public extern bool IsChanged { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsLoose { [MethodImpl] get; [MethodImpl] set; }

    [Overload("LoadPropertiesAsync")]
    [MethodImpl]
    public extern IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    [MethodImpl]
    public extern IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [Overload("GetContentsQuery")]
    [MethodImpl]
    public extern MediaItemQueryResult GetContentsQuery();
  }
}
