// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadySecureStopIterableFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(1595867493, 16916, 19870, 129, 235, 232, 159, 157, 41, 74, 238)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayReadySecureStopIterable))]
  internal interface IPlayReadySecureStopIterableFactory
  {
    PlayReadySecureStopIterable CreateInstance([Range(0, 2147483647)] byte[] publisherCertBytes);
  }
}
