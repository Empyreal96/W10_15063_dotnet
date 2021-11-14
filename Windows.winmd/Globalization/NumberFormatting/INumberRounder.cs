// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberRounder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [Guid(1416872821, 14573, 17969, 184, 12, 239, 52, 252, 72, 183, 245)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INumberRounder
  {
    int RoundInt32(int value);

    uint RoundUInt32(uint value);

    long RoundInt64(long value);

    ulong RoundUInt64(ulong value);

    float RoundSingle(float value);

    double RoundDouble(double value);
  }
}
