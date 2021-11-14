// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.ArtistProperties
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Static(typeof (IArtistPropertiesStatics), 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  public static class ArtistProperties
  {
    public static extern string Name { [MethodImpl] get; }

    public static extern string MediaId { [MethodImpl] get; }

    public static extern string LegacyId { [MethodImpl] get; }
  }
}
