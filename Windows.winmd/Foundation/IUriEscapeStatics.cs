// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IUriEscapeStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Uri))]
  [Guid(3251909306, 51236, 17490, 167, 253, 81, 43, 195, 187, 233, 161)]
  internal interface IUriEscapeStatics
  {
    string UnescapeComponent(string toUnescape);

    string EscapeComponent(string toEscape);
  }
}
