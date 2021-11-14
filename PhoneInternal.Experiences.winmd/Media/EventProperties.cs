// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.EventProperties
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IEventPropertiesStatics), 100859904)]
  [Version(100859904)]
  public static class EventProperties
  {
    public static extern string Name { [MethodImpl] get; }

    public static extern string PictureAlbumId { [MethodImpl] get; }

    public static extern string DateStart { [MethodImpl] get; }

    public static extern string Count { [MethodImpl] get; }

    public static extern string IsChanged { [MethodImpl] get; }

    public static extern string IsLoose { [MethodImpl] get; }

    public static extern string LegacyId { [MethodImpl] get; }
  }
}
