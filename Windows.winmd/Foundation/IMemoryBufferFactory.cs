// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IMemoryBufferFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ExclusiveTo(typeof (MemoryBuffer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4223982891, 9307, 4580, 175, 152, 104, 148, 35, 38, 12, 248)]
  internal interface IMemoryBufferFactory
  {
    MemoryBuffer Create([Range(0, 2147483647)] uint capacity);
  }
}
