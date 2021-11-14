// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IUriRuntimeClassWithAbsoluteCanonicalUri
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ExclusiveTo(typeof (Uri))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1972213345, 8732, 18447, 163, 57, 80, 101, 102, 115, 244, 111)]
  internal interface IUriRuntimeClassWithAbsoluteCanonicalUri
  {
    string AbsoluteCanonicalUri { get; }

    string DisplayIri { get; }
  }
}
