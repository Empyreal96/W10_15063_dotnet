// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadySoapMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayReadySoapMessage))]
  [Guid(3059350709, 52801, 16826, 138, 13, 97, 223, 95, 255, 161, 57)]
  internal interface IPlayReadySoapMessage
  {
    byte[] GetMessageBody();

    IPropertySet MessageHeaders { get; }

    Uri Uri { get; }
  }
}
