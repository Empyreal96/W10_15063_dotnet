// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IUriRuntimeClassFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(1151957359, 29246, 20447, 162, 24, 3, 62, 117, 176, 192, 132)]
  [ExclusiveTo(typeof (Uri))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUriRuntimeClassFactory
  {
    Uri CreateUri(string uri);

    Uri CreateWithRelativeUri(string baseUri, string relativeUri);
  }
}
