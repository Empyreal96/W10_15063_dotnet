// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.IWebAuthSettings
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  [Guid(2662201771, 20588, 17988, 154, 6, 222, 159, 158, 64, 17, 62)]
  [ExclusiveTo(typeof (WebAuthSettings))]
  internal interface IWebAuthSettings
  {
    string Authority { get; }

    string AuthUri { get; }

    string Id { get; }

    string Padding { get; }

    string RefreshUri { get; }

    string RequestParameters { get; }

    string Scheme { get; }

    string Scope { get; }
  }
}
