// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberRounderOption
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(990413875, 25711, 20222, 141, 72, 102, 235, 46, 73, 231, 54)]
  public interface INumberRounderOption
  {
    INumberRounder NumberRounder { get; set; }
  }
}
