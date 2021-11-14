// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.WebAuthSettings
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [Activatable(100859904)]
  public sealed class WebAuthSettings : IWebAuthSettings
  {
    [MethodImpl]
    public extern WebAuthSettings();

    public extern string Authority { [MethodImpl] get; }

    public extern string AuthUri { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern string Padding { [MethodImpl] get; }

    public extern string RefreshUri { [MethodImpl] get; }

    public extern string RequestParameters { [MethodImpl] get; }

    public extern string Scheme { [MethodImpl] get; }

    public extern string Scope { [MethodImpl] get; }
  }
}
