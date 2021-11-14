// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IMemoryBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(4223982890, 9307, 4580, 175, 152, 104, 148, 35, 38, 12, 248)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMemoryBuffer : IClosable
  {
    IMemoryBufferReference CreateReference();
  }
}
