// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IMediaItemProperties
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Guid(367072897, 5362, 17665, 149, 16, 244, 148, 93, 89, 58, 20)]
  [Version(100859904)]
  public interface IMediaItemProperties
  {
    void GetProperty(string propertyId, out IPropertyValue value);
  }
}
