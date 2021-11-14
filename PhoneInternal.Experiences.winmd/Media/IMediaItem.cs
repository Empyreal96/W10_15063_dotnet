// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IMediaItem
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Guid(4129128327, 13631, 13925, 138, 83, 161, 154, 7, 186, 126, 9)]
  [Version(100859904)]
  public interface IMediaItem
  {
    string Id { get; }

    void SetExtraProperties(IIterable<IKeyValuePair<string, object>> props);

    IAsyncOperation<IMap<string, object>> GetExtraPropertiesAsync(
      IIterable<string> propNames);
  }
}
