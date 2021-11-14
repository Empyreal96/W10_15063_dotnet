// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.SignificantDigitsNumberRounder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SignificantDigitsNumberRounder : 
    INumberRounder,
    ISignificantDigitsNumberRounder
  {
    [MethodImpl]
    public extern SignificantDigitsNumberRounder();

    [MethodImpl]
    public extern int RoundInt32(int value);

    [MethodImpl]
    public extern uint RoundUInt32(uint value);

    [MethodImpl]
    public extern long RoundInt64(long value);

    [MethodImpl]
    public extern ulong RoundUInt64(ulong value);

    [MethodImpl]
    public extern float RoundSingle(float value);

    [MethodImpl]
    public extern double RoundDouble(double value);

    public extern RoundingAlgorithm RoundingAlgorithm { [MethodImpl] get; [MethodImpl] set; }

    public extern uint SignificantDigits { [MethodImpl] get; [MethodImpl] set; }
  }
}
