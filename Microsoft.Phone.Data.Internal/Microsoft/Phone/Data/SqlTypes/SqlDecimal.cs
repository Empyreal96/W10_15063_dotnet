// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.SqlTypes.SqlDecimal
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Serialization;

namespace Microsoft.Phone.Data.SqlTypes
{
  [XmlSchemaProvider("GetXsdType")]
  public struct SqlDecimal : INullable, IComparable
  {
    internal byte m_bStatus;
    internal byte m_bLen;
    internal byte m_bPrec;
    internal byte m_bScale;
    internal uint m_data1;
    internal uint m_data2;
    internal uint m_data3;
    internal uint m_data4;
    private static readonly byte NUMERIC_MAX_PRECISION = 38;
    public static readonly byte MaxPrecision = SqlDecimal.NUMERIC_MAX_PRECISION;
    public static readonly byte MaxScale = SqlDecimal.NUMERIC_MAX_PRECISION;
    private static readonly byte x_bNullMask = 1;
    private static readonly byte x_bIsNull = 0;
    private static readonly byte x_bNotNull = 1;
    private static readonly byte x_bReverseNullMask = ~SqlDecimal.x_bNullMask;
    private static readonly byte x_bSignMask = 2;
    private static readonly byte x_bPositive = 0;
    private static readonly byte x_bNegative = 2;
    private static readonly byte x_bReverseSignMask = ~SqlDecimal.x_bSignMask;
    private static readonly uint x_uiZero = 0;
    private static readonly int x_cNumeMax = 4;
    private static readonly long x_lInt32Base = 4294967296;
    private static readonly ulong x_ulInt32Base = 4294967296;
    private static readonly ulong x_ulInt32BaseForMod = SqlDecimal.x_ulInt32Base - 1UL;
    internal static readonly ulong x_llMax = (ulong) long.MaxValue;
    private static readonly uint x_ulBase10 = 10;
    private static readonly double DUINT_BASE = (double) SqlDecimal.x_lInt32Base;
    private static readonly double DUINT_BASE2 = SqlDecimal.DUINT_BASE * SqlDecimal.DUINT_BASE;
    private static readonly double DUINT_BASE3 = SqlDecimal.DUINT_BASE2 * SqlDecimal.DUINT_BASE;
    private static readonly double DMAX_NUME = 1E+38;
    private static readonly uint DBL_DIG = 17;
    private static readonly byte x_cNumeDivScaleMin = 6;
    private static readonly uint[] x_rgulShiftBase = new uint[9]
    {
      10U,
      100U,
      1000U,
      10000U,
      100000U,
      1000000U,
      10000000U,
      100000000U,
      1000000000U
    };
    private static readonly uint[] DecimalHelpersLo = new uint[38]
    {
      10U,
      100U,
      1000U,
      10000U,
      100000U,
      1000000U,
      10000000U,
      100000000U,
      1000000000U,
      1410065408U,
      1215752192U,
      3567587328U,
      1316134912U,
      276447232U,
      2764472320U,
      1874919424U,
      1569325056U,
      2808348672U,
      2313682944U,
      1661992960U,
      3735027712U,
      2990538752U,
      4135583744U,
      2701131776U,
      1241513984U,
      3825205248U,
      3892314112U,
      268435456U,
      2684354560U,
      1073741824U,
      2147483648U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U
    };
    private static readonly uint[] DecimalHelpersMid = new uint[38]
    {
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      2U,
      23U,
      232U,
      2328U,
      23283U,
      232830U,
      2328306U,
      23283064U,
      232830643U,
      2328306436U,
      1808227885U,
      902409669U,
      434162106U,
      46653770U,
      466537709U,
      370409800U,
      3704098002U,
      2681241660U,
      1042612833U,
      1836193738U,
      1182068202U,
      3230747430U,
      2242703233U,
      952195850U,
      932023908U,
      730304488U,
      3008077584U,
      16004768U,
      160047680U
    };
    private static readonly uint[] DecimalHelpersHi = new uint[38]
    {
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      5U,
      54U,
      542U,
      5421U,
      54210U,
      542101U,
      5421010U,
      54210108U,
      542101086U,
      1126043566U,
      2670501072U,
      935206946U,
      762134875U,
      3326381459U,
      3199043520U,
      1925664130U,
      2076772117U,
      3587851993U,
      1518781562U
    };
    private static readonly uint[] DecimalHelpersHiHi = new uint[38]
    {
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      0U,
      1U,
      12U,
      126U,
      1262U,
      12621U,
      126217U,
      1262177U,
      12621774U,
      126217744U,
      1262177448U
    };
    private const int HelperTableStartIndexLo = 5;
    private const int HelperTableStartIndexMid = 15;
    private const int HelperTableStartIndexHi = 24;
    private const int HelperTableStartIndexHiHi = 33;
    private static readonly byte[] rgCLenFromPrec = new byte[38]
    {
      (byte) 1,
      (byte) 1,
      (byte) 1,
      (byte) 1,
      (byte) 1,
      (byte) 1,
      (byte) 1,
      (byte) 1,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 4,
      (byte) 4,
      (byte) 4,
      (byte) 4,
      (byte) 4,
      (byte) 4,
      (byte) 4,
      (byte) 4,
      (byte) 4,
      (byte) 4
    };
    private static readonly uint x_ulT1 = 10;
    private static readonly uint x_ulT2 = 100;
    private static readonly uint x_ulT3 = 1000;
    private static readonly uint x_ulT4 = 10000;
    private static readonly uint x_ulT5 = 100000;
    private static readonly uint x_ulT6 = 1000000;
    private static readonly uint x_ulT7 = 10000000;
    private static readonly uint x_ulT8 = 100000000;
    private static readonly uint x_ulT9 = 1000000000;
    private static readonly ulong x_dwlT10 = 10000000000;
    private static readonly ulong x_dwlT11 = 100000000000;
    private static readonly ulong x_dwlT12 = 1000000000000;
    private static readonly ulong x_dwlT13 = 10000000000000;
    private static readonly ulong x_dwlT14 = 100000000000000;
    private static readonly ulong x_dwlT15 = 1000000000000000;
    private static readonly ulong x_dwlT16 = 10000000000000000;
    private static readonly ulong x_dwlT17 = 100000000000000000;
    private static readonly ulong x_dwlT18 = 1000000000000000000;
    private static readonly ulong x_dwlT19 = 10000000000000000000;
    public static readonly SqlDecimal Null = new SqlDecimal(true);
    public static readonly SqlDecimal MinValue = SqlDecimal.Parse("-99999999999999999999999999999999999999");
    public static readonly SqlDecimal MaxValue = SqlDecimal.Parse("99999999999999999999999999999999999999");

    private byte CalculatePrecision()
    {
      int index1;
      uint[] numArray;
      uint num1;
      if (this.m_data4 != 0U)
      {
        index1 = 33;
        numArray = SqlDecimal.DecimalHelpersHiHi;
        num1 = this.m_data4;
      }
      else if (this.m_data3 != 0U)
      {
        index1 = 24;
        numArray = SqlDecimal.DecimalHelpersHi;
        num1 = this.m_data3;
      }
      else if (this.m_data2 != 0U)
      {
        index1 = 15;
        numArray = SqlDecimal.DecimalHelpersMid;
        num1 = this.m_data2;
      }
      else
      {
        index1 = 5;
        numArray = SqlDecimal.DecimalHelpersLo;
        num1 = this.m_data1;
      }
      int index2;
      if (num1 < numArray[index1])
      {
        int index3 = index1 - 2;
        if (num1 < numArray[index3])
        {
          int index4 = index3 - 2;
          index2 = num1 >= numArray[index4] ? index4 + 1 : index4 - 1;
        }
        else
          index2 = index3 + 1;
      }
      else
      {
        int index3 = index1 + 2;
        index2 = num1 >= numArray[index3] ? index3 + 1 : index3 - 1;
      }
      if (num1 >= numArray[index2])
      {
        ++index2;
        if (index2 == 37 && num1 >= numArray[index2])
          ++index2;
      }
      byte num2 = (byte) (index2 + 1);
      if (num2 > (byte) 1 && this.VerifyPrecision((byte) ((uint) num2 - 1U)))
        --num2;
      Debug.Assert((int) num2 == (int) SqlDecimal.MaxPrecision + 1 || this.VerifyPrecision(num2), "Calcualted precision too low?");
      Debug.Assert(num2 == (byte) 1 || !this.VerifyPrecision((byte) ((uint) num2 - 1U)), "Calculated precision too high?");
      byte num3 = Math.Max(num2, this.m_bScale);
      byte bPrec = this.m_bPrec;
      this.m_bPrec = SqlDecimal.MaxPrecision;
      byte num4 = this.BActualPrec();
      this.m_bPrec = bPrec;
      Debug.Assert(((int) num3 == (int) num4 ? 1 : 0) != 0, string.Format((IFormatProvider) null, "CalculatePrecision={0}, BActualPrec={1}. Results must be equal!", (object) num3, (object) num4));
      return num3;
    }

    private bool VerifyPrecision(byte precision)
    {
      Debug.Assert(precision > (byte) 0, "Precision cannot be less than 1");
      Debug.Assert((int) precision <= (int) SqlDecimal.MaxPrecision, "Precision > MaxPrecision");
      int index = checked ((int) precision - 1);
      return this.m_data4 < SqlDecimal.DecimalHelpersHiHi[index] || (int) this.m_data4 == (int) SqlDecimal.DecimalHelpersHiHi[index] && (this.m_data3 < SqlDecimal.DecimalHelpersHi[index] || (int) this.m_data3 == (int) SqlDecimal.DecimalHelpersHi[index] && (this.m_data2 < SqlDecimal.DecimalHelpersMid[index] || (int) this.m_data2 == (int) SqlDecimal.DecimalHelpersMid[index] && this.m_data1 < SqlDecimal.DecimalHelpersLo[index]));
    }

    private SqlDecimal(bool fNull)
    {
      this.m_bLen = this.m_bPrec = this.m_bScale = (byte) 0;
      this.m_bStatus = (byte) 0;
      this.m_data1 = this.m_data2 = this.m_data3 = this.m_data4 = SqlDecimal.x_uiZero;
    }

    public SqlDecimal(Decimal value)
    {
      this.m_bStatus = SqlDecimal.x_bNotNull;
      int[] bits = Decimal.GetBits(value);
      uint num = (uint) bits[3];
      this.m_data1 = (uint) bits[0];
      this.m_data2 = (uint) bits[1];
      this.m_data3 = (uint) bits[2];
      this.m_data4 = SqlDecimal.x_uiZero;
      this.m_bStatus |= ((int) num & int.MinValue) == int.MinValue ? SqlDecimal.x_bNegative : (byte) 0;
      this.m_bLen = this.m_data3 == 0U ? (this.m_data2 == 0U ? (byte) 1 : (byte) 2) : (byte) 3;
      this.m_bScale = (byte) (((int) num & 16711680) >> 16);
      this.m_bPrec = (byte) 0;
      this.m_bPrec = this.CalculatePrecision();
    }

    public SqlDecimal(int value)
    {
      this.m_bStatus = SqlDecimal.x_bNotNull;
      uint num = (uint) value;
      if (value < 0)
      {
        this.m_bStatus |= SqlDecimal.x_bNegative;
        if (value != int.MinValue)
          num = (uint) -value;
      }
      this.m_data1 = num;
      this.m_data2 = this.m_data3 = this.m_data4 = SqlDecimal.x_uiZero;
      this.m_bLen = (byte) 1;
      this.m_bPrec = SqlDecimal.BGetPrecUI4(this.m_data1);
      this.m_bScale = (byte) 0;
    }

    public SqlDecimal(long value)
    {
      this.m_bStatus = SqlDecimal.x_bNotNull;
      ulong dwlVal = (ulong) value;
      if (value < 0L)
      {
        this.m_bStatus |= SqlDecimal.x_bNegative;
        if (value != long.MinValue)
          dwlVal = (ulong) -value;
      }
      this.m_data1 = (uint) dwlVal;
      this.m_data2 = (uint) (dwlVal >> 32);
      this.m_data3 = this.m_data4 = 0U;
      this.m_bLen = this.m_data2 == 0U ? (byte) 1 : (byte) 2;
      this.m_bPrec = SqlDecimal.BGetPrecUI8(dwlVal);
      this.m_bScale = (byte) 0;
      this.AssertValid();
    }

    public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int[] bits)
    {
      SqlDecimal.CheckValidPrecScale(bPrecision, bScale);
      if (bits == null)
        throw new ArgumentNullException(nameof (bits));
      if (bits.Length != 4)
        throw new ArgumentException(SQLResource.InvalidArraySizeMessage, nameof (bits));
      this.m_bPrec = bPrecision;
      this.m_bScale = bScale;
      this.m_data1 = (uint) bits[0];
      this.m_data2 = (uint) bits[1];
      this.m_data3 = (uint) bits[2];
      this.m_data4 = (uint) bits[3];
      this.m_bLen = (byte) 1;
      for (int index = 3; index >= 0; --index)
      {
        if (bits[index] != 0)
        {
          this.m_bLen = (byte) (index + 1);
          break;
        }
      }
      this.m_bStatus = SqlDecimal.x_bNotNull;
      if (!fPositive)
        this.m_bStatus |= SqlDecimal.x_bNegative;
      if (this.FZero())
        this.SetPositive();
      if ((int) bPrecision < (int) this.CalculatePrecision())
        throw new OverflowException(SQLResource.ArithOverflowMessage);
    }

    public SqlDecimal(
      byte bPrecision,
      byte bScale,
      bool fPositive,
      int data1,
      int data2,
      int data3,
      int data4)
    {
      SqlDecimal.CheckValidPrecScale(bPrecision, bScale);
      this.m_bPrec = bPrecision;
      this.m_bScale = bScale;
      this.m_data1 = (uint) data1;
      this.m_data2 = (uint) data2;
      this.m_data3 = (uint) data3;
      this.m_data4 = (uint) data4;
      this.m_bLen = (byte) 1;
      this.m_bLen = data4 != 0 ? (byte) 4 : (data3 != 0 ? (byte) 3 : (data2 != 0 ? (byte) 2 : (byte) 1));
      this.m_bStatus = SqlDecimal.x_bNotNull;
      if (!fPositive)
        this.m_bStatus |= SqlDecimal.x_bNegative;
      if (this.FZero())
        this.SetPositive();
      if ((int) bPrecision < (int) this.CalculatePrecision())
        throw new OverflowException(SQLResource.ArithOverflowMessage);
    }

    public SqlDecimal(double dVal)
      : this(false)
    {
      this.m_bStatus = SqlDecimal.x_bNotNull;
      if (dVal < 0.0)
      {
        dVal = -dVal;
        this.m_bStatus |= SqlDecimal.x_bNegative;
      }
      double num1 = dVal < SqlDecimal.DMAX_NUME ? Math.Floor(dVal) : throw new OverflowException(SQLResource.ArithOverflowMessage);
      double num2 = dVal - num1;
      this.m_bPrec = SqlDecimal.NUMERIC_MAX_PRECISION;
      this.m_bLen = (byte) 1;
      if (num1 > 0.0)
      {
        dVal = Math.Floor(num1 / SqlDecimal.DUINT_BASE);
        this.m_data1 = (uint) (num1 - dVal * SqlDecimal.DUINT_BASE);
        double num3 = dVal;
        if (num3 > 0.0)
        {
          dVal = Math.Floor(num3 / SqlDecimal.DUINT_BASE);
          this.m_data2 = (uint) (num3 - dVal * SqlDecimal.DUINT_BASE);
          double num4 = dVal;
          ++this.m_bLen;
          if (num4 > 0.0)
          {
            dVal = Math.Floor(num4 / SqlDecimal.DUINT_BASE);
            this.m_data3 = (uint) (num4 - dVal * SqlDecimal.DUINT_BASE);
            double num5 = dVal;
            ++this.m_bLen;
            if (num5 > 0.0)
            {
              dVal = Math.Floor(num5 / SqlDecimal.DUINT_BASE);
              this.m_data4 = (uint) (num5 - dVal * SqlDecimal.DUINT_BASE);
              ++this.m_bLen;
            }
          }
        }
      }
      uint num6 = this.FZero() ? 0U : (uint) this.CalculatePrecision();
      SQLDebug.Check(num6 <= (uint) SqlDecimal.NUMERIC_MAX_PRECISION, "ulLen <= NUMERIC_MAX_PRECISION", "");
      if (num6 > SqlDecimal.DBL_DIG)
      {
        uint num3 = num6 - SqlDecimal.DBL_DIG;
        uint num4;
        do
        {
          num4 = this.DivByULong(10U);
          --num3;
        }
        while (num3 > 0U);
        uint num5 = num6 - SqlDecimal.DBL_DIG;
        if (num4 >= 5U)
        {
          this.AddULong(1U);
          num6 = (uint) this.CalculatePrecision() + num5;
        }
        do
        {
          this.MultByULong(10U);
          --num5;
        }
        while (num5 > 0U);
      }
      this.m_bScale = num6 < SqlDecimal.DBL_DIG ? (byte) ((int) SqlDecimal.DBL_DIG - (int) num6) : (byte) 0;
      this.m_bPrec = (byte) (num6 + (uint) this.m_bScale);
      if (this.m_bScale > (byte) 0)
      {
        uint bScale = (uint) this.m_bScale;
        do
        {
          uint num3 = bScale >= 9U ? 9U : bScale;
          double d = num2 * (double) SqlDecimal.x_rgulShiftBase[(int) num3 - 1];
          bScale -= num3;
          this.MultByULong(SqlDecimal.x_rgulShiftBase[(int) num3 - 1]);
          this.AddULong((uint) d);
          num2 = d - Math.Floor(d);
        }
        while (bScale > 0U);
      }
      if (num2 >= 0.5)
        this.AddULong(1U);
      if (this.FZero())
        this.SetPositive();
      this.AssertValid();
    }

    private SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive)
    {
      SqlDecimal.CheckValidPrecScale(bPrec, bScale);
      SQLDebug.Check(rglData.Length >= 4);
      this.m_bLen = bLen;
      this.m_bPrec = bPrec;
      this.m_bScale = bScale;
      this.m_data1 = rglData[0];
      this.m_data2 = rglData[1];
      this.m_data3 = rglData[2];
      this.m_data4 = rglData[3];
      this.m_bStatus = SqlDecimal.x_bNotNull;
      if (!fPositive)
        this.m_bStatus |= SqlDecimal.x_bNegative;
      if (!this.FZero())
        return;
      this.SetPositive();
    }

    public bool IsNull => ((int) this.m_bStatus & (int) SqlDecimal.x_bNullMask) == (int) SqlDecimal.x_bIsNull;

    public Decimal Value => this.ToDecimal();

    public bool IsPositive
    {
      get
      {
        if (this.IsNull)
          throw new SqlNullValueException();
        return ((int) this.m_bStatus & (int) SqlDecimal.x_bSignMask) == (int) SqlDecimal.x_bPositive;
      }
    }

    private void SetPositive()
    {
      SQLDebug.Check(!this.IsNull);
      this.m_bStatus &= SqlDecimal.x_bReverseSignMask;
    }

    private void SetSignBit(bool fPositive)
    {
      SQLDebug.Check(!this.IsNull);
      this.m_bStatus = fPositive ? (byte) ((int) this.m_bStatus & (int) SqlDecimal.x_bReverseSignMask) : (byte) ((int) this.m_bStatus | (int) SqlDecimal.x_bNegative);
    }

    public byte Precision
    {
      get
      {
        if (this.IsNull)
          throw new SqlNullValueException();
        return this.m_bPrec;
      }
    }

    public byte Scale
    {
      get
      {
        if (this.IsNull)
          throw new SqlNullValueException();
        return this.m_bScale;
      }
    }

    public int[] Data
    {
      get
      {
        if (this.IsNull)
          throw new SqlNullValueException();
        return new int[4]
        {
          (int) this.m_data1,
          (int) this.m_data2,
          (int) this.m_data3,
          (int) this.m_data4
        };
      }
    }

    public byte[] BinData
    {
      get
      {
        if (this.IsNull)
          throw new SqlNullValueException();
        int data1 = (int) this.m_data1;
        int data2 = (int) this.m_data2;
        int data3 = (int) this.m_data3;
        int data4 = (int) this.m_data4;
        byte[] numArray = new byte[16];
        numArray[0] = (byte) (data1 & (int) byte.MaxValue);
        int num1 = data1 >> 8;
        numArray[1] = (byte) (num1 & (int) byte.MaxValue);
        int num2 = num1 >> 8;
        numArray[2] = (byte) (num2 & (int) byte.MaxValue);
        numArray[3] = (byte) (num2 >> 8 & (int) byte.MaxValue);
        numArray[4] = (byte) (data2 & (int) byte.MaxValue);
        int num3 = data2 >> 8;
        numArray[5] = (byte) (num3 & (int) byte.MaxValue);
        int num4 = num3 >> 8;
        numArray[6] = (byte) (num4 & (int) byte.MaxValue);
        numArray[7] = (byte) (num4 >> 8 & (int) byte.MaxValue);
        numArray[8] = (byte) (data3 & (int) byte.MaxValue);
        int num5 = data3 >> 8;
        numArray[9] = (byte) (num5 & (int) byte.MaxValue);
        int num6 = num5 >> 8;
        numArray[10] = (byte) (num6 & (int) byte.MaxValue);
        numArray[11] = (byte) (num6 >> 8 & (int) byte.MaxValue);
        numArray[12] = (byte) (data4 & (int) byte.MaxValue);
        int num7 = data4 >> 8;
        numArray[13] = (byte) (num7 & (int) byte.MaxValue);
        int num8 = num7 >> 8;
        numArray[14] = (byte) (num8 & (int) byte.MaxValue);
        numArray[15] = (byte) (num8 >> 8 & (int) byte.MaxValue);
        return numArray;
      }
    }

    public override string ToString()
    {
      if (this.IsNull)
        return SQLResource.NullString;
      this.AssertValid();
      uint[] rgulU = new uint[4]
      {
        this.m_data1,
        this.m_data2,
        this.m_data3,
        this.m_data4
      };
      int bLen = (int) this.m_bLen;
      char[] chArray1 = new char[(int) SqlDecimal.NUMERIC_MAX_PRECISION + 1];
      int index = 0;
      while (bLen > 1 || rgulU[0] != 0U)
      {
        uint iulR;
        SqlDecimal.MpDiv1(rgulU, ref bLen, SqlDecimal.x_ulBase10, out iulR);
        chArray1[index++] = SqlDecimal.ChFromDigit(iulR);
      }
      while (index <= (int) this.m_bScale)
        chArray1[index++] = SqlDecimal.ChFromDigit(0U);
      int num1 = 0;
      int num2 = 0;
      if (this.m_bScale > (byte) 0)
        num1 = 1;
      char[] chArray2;
      if (this.IsPositive)
      {
        chArray2 = new char[num1 + index];
      }
      else
      {
        chArray2 = new char[num1 + index + 1];
        chArray2[num2++] = '-';
      }
      while (index > 0)
      {
        if (index-- == (int) this.m_bScale)
          chArray2[num2++] = '.';
        chArray2[num2++] = chArray1[index];
      }
      this.AssertValid();
      return new string(chArray2);
    }

    public static SqlDecimal Parse(string s)
    {
      switch (s)
      {
        case "NULL":
          return SqlDecimal.Null;
        case null:
          throw new ArgumentNullException(nameof (s));
        default:
          SqlDecimal sqlDecimal = SqlDecimal.Null;
          char[] charArray = s.ToCharArray();
          int length = charArray.Length;
          int num1 = -1;
          int index = 0;
          sqlDecimal.m_bPrec = (byte) 1;
          sqlDecimal.m_bScale = (byte) 0;
          sqlDecimal.SetToZero();
          while (length != 0 && charArray[length - 1] == ' ')
            --length;
          if (length == 0)
            throw new FormatException(SQLResource.FormatMessage);
          while (charArray[index] == ' ')
          {
            ++index;
            --length;
          }
          if (charArray[index] == '-')
          {
            sqlDecimal.SetSignBit(false);
            ++index;
            --length;
          }
          else
          {
            sqlDecimal.SetSignBit(true);
            if (charArray[index] == '+')
            {
              ++index;
              --length;
            }
          }
          for (; length > 2 && charArray[index] == '0'; --length)
            ++index;
          if (2 == length && '0' == charArray[index] && '.' == charArray[index + 1])
          {
            charArray[index] = '.';
            charArray[index + 1] = '0';
          }
          if (length == 0 || length > (int) SqlDecimal.NUMERIC_MAX_PRECISION + 1)
            throw new FormatException(SQLResource.FormatMessage);
          for (; length > 1 && charArray[index] == '0'; --length)
            ++index;
          int num2;
          for (num2 = 0; num2 < length; ++num2)
          {
            char ch1 = charArray[index];
            ++index;
            if (ch1 >= '0' && ch1 <= '9')
            {
              char ch2 = (char) ((uint) ch1 - 48U);
              sqlDecimal.MultByULong(SqlDecimal.x_ulBase10);
              sqlDecimal.AddULong((uint) ch2);
            }
            else
              num1 = ch1 == '.' && num1 < 0 ? num2 : throw new FormatException(SQLResource.FormatMessage);
          }
          if (num1 < 0)
          {
            sqlDecimal.m_bPrec = (byte) num2;
            sqlDecimal.m_bScale = (byte) 0;
          }
          else
          {
            sqlDecimal.m_bPrec = (byte) (num2 - 1);
            ref SqlDecimal local = ref sqlDecimal;
            local.m_bScale = (byte) ((uint) local.m_bPrec - (uint) num1);
          }
          if ((int) sqlDecimal.m_bPrec > (int) SqlDecimal.NUMERIC_MAX_PRECISION)
            throw new FormatException(SQLResource.FormatMessage);
          if (sqlDecimal.m_bPrec == (byte) 0)
            throw new FormatException(SQLResource.FormatMessage);
          if (sqlDecimal.FZero())
            sqlDecimal.SetPositive();
          sqlDecimal.AssertValid();
          return sqlDecimal;
      }
    }

    public double ToDouble()
    {
      if (this.IsNull)
        throw new SqlNullValueException();
      double num = ((((double) this.m_data4 * (double) SqlDecimal.x_lInt32Base + (double) this.m_data3) * (double) SqlDecimal.x_lInt32Base + (double) this.m_data2) * (double) SqlDecimal.x_lInt32Base + (double) this.m_data1) / Math.Pow(10.0, (double) this.m_bScale);
      return !this.IsPositive ? -num : num;
    }

    private Decimal ToDecimal()
    {
      if (this.IsNull)
        throw new SqlNullValueException();
      if (this.m_data4 != 0U || this.m_bScale > (byte) 28)
        throw new OverflowException(SQLResource.ConversionOverflowMessage);
      return new Decimal((int) this.m_data1, (int) this.m_data2, (int) this.m_data3, !this.IsPositive, this.m_bScale);
    }

    public static implicit operator SqlDecimal(Decimal x) => new SqlDecimal(x);

    public static explicit operator SqlDecimal(double x) => new SqlDecimal(x);

    public static implicit operator SqlDecimal(long x) => new SqlDecimal(new Decimal(x));

    public static explicit operator Decimal(SqlDecimal x) => x.Value;

    public static SqlDecimal operator -(SqlDecimal x)
    {
      if (x.IsNull)
        return SqlDecimal.Null;
      SqlDecimal sqlDecimal = x;
      if (sqlDecimal.FZero())
      {
        sqlDecimal.SetPositive();
      }
      else
      {
        ref SqlDecimal local = ref sqlDecimal;
        local.SetSignBit(!local.IsPositive);
      }
      return sqlDecimal;
    }

    public static SqlDecimal operator +(SqlDecimal x, SqlDecimal y)
    {
      if (x.IsNull || y.IsNull)
        return SqlDecimal.Null;
      bool fPositive = true;
      x.AssertValid();
      y.AssertValid();
      bool isPositive = x.IsPositive;
      bool flag1 = y.IsPositive;
      int bScale1 = (int) x.m_bScale;
      int bScale2 = (int) y.m_bScale;
      int num1 = Math.Max((int) x.m_bPrec - bScale1, (int) y.m_bPrec - bScale2);
      SQLDebug.Check(num1 <= (int) SqlDecimal.MaxPrecision);
      int num2 = Math.Max(bScale1, bScale2);
      SQLDebug.Check(num2 <= (int) SqlDecimal.MaxScale);
      int val2 = num1 + num2 + 1;
      int num3 = Math.Min((int) SqlDecimal.MaxPrecision, val2);
      SQLDebug.Check(num3 - num1 >= 0);
      if (num3 - num1 < num2)
        num2 = num3 - num1;
      if (bScale1 != num2)
        x.AdjustScale(num2 - bScale1, true);
      if (bScale2 != num2)
        y.AdjustScale(num2 - bScale2, true);
      if (!isPositive)
      {
        bool flag2 = !isPositive;
        flag1 = !flag1;
        fPositive = !fPositive;
      }
      int num4 = (int) x.m_bLen;
      int bLen1 = (int) y.m_bLen;
      uint[] rglData = new uint[4]
      {
        x.m_data1,
        x.m_data2,
        x.m_data3,
        x.m_data4
      };
      uint[] numArray1 = new uint[4]
      {
        y.m_data1,
        y.m_data2,
        y.m_data3,
        y.m_data4
      };
      byte bLen2;
      if (flag1)
      {
        ulong num5 = 0;
        int index;
        for (index = 0; index < num4 || index < bLen1; ++index)
        {
          if (index < num4)
            num5 += (ulong) rglData[index];
          if (index < bLen1)
            num5 += (ulong) numArray1[index];
          rglData[index] = (uint) num5;
          num5 >>= 32;
        }
        if (num5 != 0UL)
        {
          SQLDebug.Check(num5 < SqlDecimal.x_ulInt32Base);
          if (index == SqlDecimal.x_cNumeMax)
            throw new OverflowException(SQLResource.ArithOverflowMessage);
          rglData[index] = (uint) num5;
          ++index;
        }
        bLen2 = (byte) index;
      }
      else
      {
        int num5 = 0;
        if (x.LAbsCmp(y) < 0)
        {
          fPositive = !fPositive;
          uint[] numArray2 = numArray1;
          numArray1 = rglData;
          rglData = numArray2;
          num4 = bLen1;
          bLen1 = (int) x.m_bLen;
        }
        ulong num6 = SqlDecimal.x_ulInt32Base;
        for (int index = 0; index < num4 || index < bLen1; ++index)
        {
          if (index < num4)
            num6 += (ulong) rglData[index];
          if (index < bLen1)
            num6 -= (ulong) numArray1[index];
          rglData[index] = (uint) num6;
          if (rglData[index] != 0U)
            num5 = index;
          num6 = (num6 >> 32) + SqlDecimal.x_ulInt32BaseForMod;
        }
        bLen2 = (byte) (num5 + 1);
      }
      SqlDecimal sqlDecimal = new SqlDecimal(rglData, bLen2, (byte) num3, (byte) num2, fPositive);
      if (sqlDecimal.FGt10_38() || (int) sqlDecimal.CalculatePrecision() > (int) SqlDecimal.NUMERIC_MAX_PRECISION)
        throw new OverflowException(SQLResource.ArithOverflowMessage);
      if (sqlDecimal.FZero())
        sqlDecimal.SetPositive();
      sqlDecimal.AssertValid();
      return sqlDecimal;
    }

    public static SqlDecimal operator -(SqlDecimal x, SqlDecimal y) => x + -y;

    public static SqlDecimal operator *(SqlDecimal x, SqlDecimal y)
    {
      x.AssertValid();
      y.AssertValid();
      if (x.IsNull || y.IsNull)
        return SqlDecimal.Null;
      int bLen = (int) y.m_bLen;
      int val1 = (int) x.m_bScale + (int) y.m_bScale;
      int val2 = val1;
      int num1 = (int) x.m_bPrec - (int) x.m_bScale + ((int) y.m_bPrec - (int) y.m_bScale) + 1;
      int num2 = val2 + num1;
      if (num2 > (int) SqlDecimal.NUMERIC_MAX_PRECISION)
        num2 = (int) SqlDecimal.NUMERIC_MAX_PRECISION;
      if (val2 > (int) SqlDecimal.NUMERIC_MAX_PRECISION)
        val2 = (int) SqlDecimal.NUMERIC_MAX_PRECISION;
      int num3 = Math.Max(Math.Min(num2 - num1, val2), Math.Min(val1, (int) SqlDecimal.x_cNumeDivScaleMin));
      int digits = num3 - val1;
      bool fPositive = x.IsPositive == y.IsPositive;
      uint[] numArray1 = new uint[4]
      {
        x.m_data1,
        x.m_data2,
        x.m_data3,
        x.m_data4
      };
      uint[] numArray2 = new uint[4]
      {
        y.m_data1,
        y.m_data2,
        y.m_data3,
        y.m_data4
      };
      uint[] numArray3 = new uint[9];
      int index1 = 0;
      for (int index2 = 0; index2 < (int) x.m_bLen; ++index2)
      {
        uint num4 = numArray1[index2];
        ulong num5 = 0;
        index1 = index2;
        for (int index3 = 0; index3 < bLen; ++index3)
        {
          ulong num6 = num5 + (ulong) numArray3[index1];
          ulong num7 = (ulong) numArray2[index3];
          ulong num8 = (ulong) num4 * num7 + num6;
          ulong num9 = num8 >= num6 ? 0UL : SqlDecimal.x_ulInt32Base;
          numArray3[index1++] = (uint) num8;
          num5 = (num8 >> 32) + num9;
          SQLDebug.Check(num5 < SqlDecimal.x_ulInt32Base * 2UL);
        }
        SQLDebug.Check(num5 < SqlDecimal.x_ulInt32Base);
        if (num5 != 0UL)
          numArray3[index1++] = (uint) num5;
      }
      while (numArray3[index1] == 0U && index1 > 0)
        --index1;
      int ciulU = index1 + 1;
      if (digits != 0)
      {
        if (digits < 0)
        {
          SQLDebug.Check((int) SqlDecimal.NUMERIC_MAX_PRECISION == num2);
          uint iulD;
          uint iulR;
          do
          {
            if (digits <= -9)
            {
              iulD = SqlDecimal.x_rgulShiftBase[8];
              digits += 9;
            }
            else
            {
              iulD = SqlDecimal.x_rgulShiftBase[-digits - 1];
              digits = 0;
            }
            SqlDecimal.MpDiv1(numArray3, ref ciulU, iulD, out iulR);
          }
          while (digits != 0);
          if (ciulU > SqlDecimal.x_cNumeMax)
            throw new OverflowException(SQLResource.ArithOverflowMessage);
          for (int index2 = ciulU; index2 < SqlDecimal.x_cNumeMax; ++index2)
            numArray3[index2] = 0U;
          SqlDecimal sqlDecimal = new SqlDecimal(numArray3, (byte) ciulU, (byte) num2, (byte) num3, fPositive);
          if (sqlDecimal.FGt10_38())
            throw new OverflowException(SQLResource.ArithOverflowMessage);
          sqlDecimal.AssertValid();
          if (iulR >= iulD / 2U)
            sqlDecimal.AddULong(1U);
          if (sqlDecimal.FZero())
            sqlDecimal.SetPositive();
          return sqlDecimal;
        }
        if (ciulU > SqlDecimal.x_cNumeMax)
          throw new OverflowException(SQLResource.ArithOverflowMessage);
        for (int index2 = ciulU; index2 < SqlDecimal.x_cNumeMax; ++index2)
          numArray3[index2] = 0U;
        SqlDecimal sqlDecimal1 = new SqlDecimal(numArray3, (byte) ciulU, (byte) num2, (byte) val1, fPositive);
        if (sqlDecimal1.FZero())
          sqlDecimal1.SetPositive();
        sqlDecimal1.AssertValid();
        sqlDecimal1.AdjustScale(digits, true);
        return sqlDecimal1;
      }
      if (ciulU > SqlDecimal.x_cNumeMax)
        throw new OverflowException(SQLResource.ArithOverflowMessage);
      for (int index2 = ciulU; index2 < SqlDecimal.x_cNumeMax; ++index2)
        numArray3[index2] = 0U;
      SqlDecimal sqlDecimal2 = new SqlDecimal(numArray3, (byte) ciulU, (byte) num2, (byte) num3, fPositive);
      if (sqlDecimal2.FGt10_38())
        throw new OverflowException(SQLResource.ArithOverflowMessage);
      if (sqlDecimal2.FZero())
        sqlDecimal2.SetPositive();
      sqlDecimal2.AssertValid();
      return sqlDecimal2;
    }

    public static SqlDecimal operator /(SqlDecimal x, SqlDecimal y)
    {
      if (x.IsNull || y.IsNull)
        return SqlDecimal.Null;
      x.AssertValid();
      y.AssertValid();
      if (y.FZero())
        throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
      bool fPositive = x.IsPositive == y.IsPositive;
      int num1 = Math.Max((int) x.m_bScale + (int) y.m_bPrec + 1, (int) SqlDecimal.x_cNumeDivScaleMin);
      int val1 = (int) x.m_bPrec - (int) x.m_bScale + (int) y.m_bScale;
      int num2 = num1 + (int) x.m_bPrec + (int) y.m_bPrec + 1;
      int val2 = Math.Min(num1, (int) SqlDecimal.x_cNumeDivScaleMin);
      int num3 = Math.Min(val1, (int) SqlDecimal.NUMERIC_MAX_PRECISION);
      int num4 = num3 + num1;
      if (num4 > (int) SqlDecimal.NUMERIC_MAX_PRECISION)
        num4 = (int) SqlDecimal.NUMERIC_MAX_PRECISION;
      int num5 = Math.Max(Math.Min(num4 - num3, num1), val2);
      int digits = num5 - (int) x.m_bScale + (int) y.m_bScale;
      x.AdjustScale(digits, true);
      uint[] rgulU = new uint[4]
      {
        x.m_data1,
        x.m_data2,
        x.m_data3,
        x.m_data4
      };
      uint[] rgulD = new uint[4]
      {
        y.m_data1,
        y.m_data2,
        y.m_data3,
        y.m_data4
      };
      uint[] rgulR = new uint[SqlDecimal.x_cNumeMax + 1];
      uint[] numArray = new uint[SqlDecimal.x_cNumeMax];
      int ciulQ;
      SqlDecimal.MpDiv(rgulU, (int) x.m_bLen, rgulD, (int) y.m_bLen, numArray, out ciulQ, rgulR, out int _);
      SqlDecimal.ZeroToMaxLen(numArray, ciulQ);
      SqlDecimal sqlDecimal = new SqlDecimal(numArray, (byte) ciulQ, (byte) num4, (byte) num5, fPositive);
      if (sqlDecimal.FZero())
        sqlDecimal.SetPositive();
      sqlDecimal.AssertValid();
      return sqlDecimal;
    }

    [Conditional("DEBUG")]
    private void AssertValid()
    {
      if (this.IsNull)
        return;
      SQLDebug.Check((int) this.m_bScale <= (int) SqlDecimal.NUMERIC_MAX_PRECISION, "m_bScale <= NUMERIC_MAX_PRECISION", "In AssertValid");
      SQLDebug.Check((int) this.m_bScale <= (int) this.m_bPrec, "m_bScale <= m_bPrec", "In AssertValid");
      SQLDebug.Check(this.m_bScale >= (byte) 0, "m_bScale >= 0", "In AssertValid");
      SQLDebug.Check(this.m_bPrec > (byte) 0, "m_bPrec > 0", "In AssertValid");
      SQLDebug.Check((int) SqlDecimal.CLenFromPrec(this.m_bPrec) >= (int) this.m_bLen, "CLenFromPrec(m_bPrec) >= m_bLen", "In AssertValid");
      SQLDebug.Check((int) this.m_bLen <= SqlDecimal.x_cNumeMax, "m_bLen <= x_cNumeMax", "In AssertValid");
      uint[] numArray = new uint[4]
      {
        this.m_data1,
        this.m_data2,
        this.m_data3,
        this.m_data4
      };
      if (numArray[(int) this.m_bLen - 1] == 0U)
        SQLDebug.Check(this.m_bLen == (byte) 1, "m_bLen == 1", "In AssertValid");
      for (int bLen = (int) this.m_bLen; bLen < SqlDecimal.x_cNumeMax; ++bLen)
        SQLDebug.Check(numArray[bLen] == 0U, "rglData[iulData] == 0", "In AssertValid");
    }

    private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur)
    {
      SQLDebug.Check(rgulData.Length == SqlDecimal.x_cNumeMax, "rgulData.Length == x_cNumeMax", "Invalid array length");
      switch (cUI4sCur)
      {
        case 1:
          rgulData[1] = rgulData[2] = rgulData[3] = 0U;
          break;
        case 2:
          rgulData[2] = rgulData[3] = 0U;
          break;
        case 3:
          rgulData[3] = 0U;
          break;
      }
    }

    private static byte CLenFromPrec(byte bPrec)
    {
      SQLDebug.Check((int) bPrec <= (int) SqlDecimal.MaxPrecision && bPrec > (byte) 0, "bPrec <= MaxPrecision && bPrec > 0", "Invalid numeric precision");
      return SqlDecimal.rgCLenFromPrec[(int) bPrec - 1];
    }

    private bool FZero() => this.m_data1 == 0U && this.m_bLen <= (byte) 1;

    private bool FGt10_38()
    {
      if (this.m_data4 < 1262177448U || this.m_bLen != (byte) 4)
        return false;
      if (this.m_data4 > 1262177448U || this.m_data3 > 1518781562U)
        return true;
      return this.m_data3 == 1518781562U && this.m_data2 >= 160047680U;
    }

    private bool FGt10_38(uint[] rglData)
    {
      SQLDebug.Check(rglData.Length == 4, "rglData.Length == 4", "Wrong array length: " + rglData.Length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      if (rglData[3] < 1262177448U)
        return false;
      if (rglData[3] > 1262177448U || rglData[2] > 1518781562U)
        return true;
      return rglData[2] == 1518781562U && rglData[1] >= 160047680U;
    }

    private static byte BGetPrecUI4(uint value) => value >= SqlDecimal.x_ulT4 ? (value >= SqlDecimal.x_ulT8 ? (value >= SqlDecimal.x_ulT9 ? (byte) 10 : (byte) 9) : (value >= SqlDecimal.x_ulT6 ? (value >= SqlDecimal.x_ulT7 ? (byte) 8 : (byte) 7) : (value >= SqlDecimal.x_ulT5 ? (byte) 6 : (byte) 5))) : (value >= SqlDecimal.x_ulT2 ? (value >= SqlDecimal.x_ulT3 ? (byte) 4 : (byte) 3) : (value >= SqlDecimal.x_ulT1 ? (byte) 2 : (byte) 1));

    private static byte BGetPrecUI8(uint ulU0, uint ulU1) => SqlDecimal.BGetPrecUI8((ulong) ulU0 + ((ulong) ulU1 << 32));

    private static byte BGetPrecUI8(ulong dwlVal)
    {
      int num1;
      if (dwlVal < (ulong) SqlDecimal.x_ulT8)
      {
        uint num2 = (uint) dwlVal;
        num1 = num2 >= SqlDecimal.x_ulT4 ? (num2 >= SqlDecimal.x_ulT6 ? (num2 >= SqlDecimal.x_ulT7 ? 8 : 7) : (num2 >= SqlDecimal.x_ulT5 ? 6 : 5)) : (num2 >= SqlDecimal.x_ulT2 ? (num2 >= SqlDecimal.x_ulT3 ? 4 : 3) : (num2 >= SqlDecimal.x_ulT1 ? 2 : 1));
      }
      else
        num1 = dwlVal >= SqlDecimal.x_dwlT16 ? (dwlVal >= SqlDecimal.x_dwlT18 ? (dwlVal >= SqlDecimal.x_dwlT19 ? 20 : 19) : (dwlVal >= SqlDecimal.x_dwlT17 ? 18 : 17)) : (dwlVal >= SqlDecimal.x_dwlT12 ? (dwlVal >= SqlDecimal.x_dwlT14 ? (dwlVal >= SqlDecimal.x_dwlT15 ? 16 : 15) : (dwlVal >= SqlDecimal.x_dwlT13 ? 14 : 13)) : (dwlVal >= SqlDecimal.x_dwlT10 ? (dwlVal >= SqlDecimal.x_dwlT11 ? 12 : 11) : (dwlVal >= (ulong) SqlDecimal.x_ulT9 ? 10 : 9)));
      return (byte) num1;
    }

    private byte BActualPrec()
    {
      if (this.m_bPrec == (byte) 0 || this.m_bLen < (byte) 1)
        return 0;
      int bLen = (int) this.m_bLen;
      int num1;
      switch (bLen)
      {
        case 1:
          num1 = (int) SqlDecimal.BGetPrecUI4(this.m_data1);
          break;
        case 2:
          num1 = (int) SqlDecimal.BGetPrecUI8(this.m_data1, this.m_data2);
          break;
        default:
          uint[] rgulU = new uint[4]
          {
            this.m_data1,
            this.m_data2,
            this.m_data3,
            this.m_data4
          };
          int num2 = 0;
          do
          {
            SqlDecimal.MpDiv1(rgulU, ref bLen, 1000000000U, out uint _);
            num2 += 9;
          }
          while (bLen > 2);
          SQLDebug.Check(num2 == 9 || num2 == 18 || num2 == 27);
          num1 = num2 + (int) SqlDecimal.BGetPrecUI8(rgulU[0], rgulU[1]);
          break;
      }
      return num1 >= (int) this.m_bScale ? (byte) num1 : this.m_bScale;
    }

    private void AddULong(uint ulAdd)
    {
      ulong num1 = (ulong) ulAdd;
      int bLen = (int) this.m_bLen;
      uint[] numArray = new uint[4]
      {
        this.m_data1,
        this.m_data2,
        this.m_data3,
        this.m_data4
      };
      int index = 0;
      do
      {
        ulong num2 = num1 + (ulong) numArray[index];
        numArray[index] = (uint) num2;
        num1 = num2 >> 32;
        if (num1 == 0UL)
        {
          this.StoreFromWorkingArray(numArray);
          return;
        }
        ++index;
      }
      while (index < bLen);
      SQLDebug.Check(num1 < SqlDecimal.x_ulInt32Base, "dwlAccum < x_lInt32Base", "");
      if (index == SqlDecimal.x_cNumeMax)
        throw new OverflowException(SQLResource.ArithOverflowMessage);
      numArray[index] = (uint) num1;
      ++this.m_bLen;
      if (this.FGt10_38(numArray))
        throw new OverflowException(SQLResource.ArithOverflowMessage);
      this.StoreFromWorkingArray(numArray);
    }

    private void MultByULong(uint uiMultiplier)
    {
      int bLen = (int) this.m_bLen;
      ulong num1 = 0;
      uint[] numArray = new uint[4]
      {
        this.m_data1,
        this.m_data2,
        this.m_data3,
        this.m_data4
      };
      for (int index = 0; index < bLen; ++index)
      {
        SQLDebug.Check(num1 < SqlDecimal.x_ulInt32Base);
        ulong num2 = (ulong) numArray[index] * (ulong) uiMultiplier;
        ulong num3 = num1 + num2;
        ulong num4 = num3 >= num2 ? 0UL : SqlDecimal.x_ulInt32Base;
        numArray[index] = (uint) num3;
        num1 = (num3 >> 32) + num4;
      }
      if (num1 != 0UL)
      {
        SQLDebug.Check(num1 < SqlDecimal.x_ulInt32Base, "dwlAccum < x_dwlBaseUI4", "Integer overflow");
        if (bLen == SqlDecimal.x_cNumeMax)
          throw new OverflowException(SQLResource.ArithOverflowMessage);
        numArray[bLen] = (uint) num1;
        ++this.m_bLen;
      }
      if (this.FGt10_38(numArray))
        throw new OverflowException(SQLResource.ArithOverflowMessage);
      this.StoreFromWorkingArray(numArray);
    }

    private uint DivByULong(uint iDivisor)
    {
      ulong num1 = (ulong) iDivisor;
      ulong num2 = 0;
      bool flag = true;
      if (num1 == 0UL)
        throw new DivideByZeroException(SQLResource.DivideByZeroMessage);
      uint[] rguiData = new uint[4]
      {
        this.m_data1,
        this.m_data2,
        this.m_data3,
        this.m_data4
      };
      for (int bLen = (int) this.m_bLen; bLen > 0; --bLen)
      {
        SQLDebug.Check(num2 < num1);
        ulong num3 = (num2 << 32) + (ulong) rguiData[bLen - 1];
        SQLDebug.Check(num3 / num1 < SqlDecimal.x_ulInt32Base);
        uint num4 = (uint) (num3 / num1);
        rguiData[bLen - 1] = num4;
        num2 = num3 % num1;
        if (flag && num4 == 0U)
          --this.m_bLen;
        else
          flag = false;
      }
      this.StoreFromWorkingArray(rguiData);
      if (flag)
        this.m_bLen = (byte) 1;
      this.AssertValid();
      SQLDebug.Check(num2 < SqlDecimal.x_ulInt32Base);
      return (uint) num2;
    }

    internal void AdjustScale(int digits, bool fRound)
    {
      SQLDebug.Check(!this.IsNull, "!IsNull", "In AdjustScale");
      bool flag = false;
      int num1 = digits;
      if (num1 + (int) this.m_bScale < 0)
        throw new SqlTruncateException();
      if (num1 + (int) this.m_bScale > (int) SqlDecimal.NUMERIC_MAX_PRECISION)
        throw new OverflowException(SQLResource.ArithOverflowMessage);
      byte num2 = (byte) ((uint) num1 + (uint) this.m_bScale);
      byte num3 = (byte) Math.Min((int) SqlDecimal.NUMERIC_MAX_PRECISION, Math.Max(1, num1 + (int) this.m_bPrec));
      if (num1 > 0)
      {
        this.m_bScale = num2;
        this.m_bPrec = num3;
        while (num1 > 0)
        {
          uint uiMultiplier;
          if (num1 >= 9)
          {
            uiMultiplier = SqlDecimal.x_rgulShiftBase[8];
            num1 -= 9;
          }
          else
          {
            uiMultiplier = SqlDecimal.x_rgulShiftBase[num1 - 1];
            num1 = 0;
          }
          this.MultByULong(uiMultiplier);
        }
      }
      else if (num1 < 0)
      {
        uint iDivisor;
        uint num4;
        do
        {
          if (num1 <= -9)
          {
            iDivisor = SqlDecimal.x_rgulShiftBase[8];
            num1 += 9;
          }
          else
          {
            iDivisor = SqlDecimal.x_rgulShiftBase[-num1 - 1];
            num1 = 0;
          }
          num4 = this.DivByULong(iDivisor);
        }
        while (num1 < 0);
        flag = num4 >= iDivisor / 2U;
        this.m_bScale = num2;
        this.m_bPrec = num3;
      }
      this.AssertValid();
      if (flag & fRound)
      {
        this.AddULong(1U);
      }
      else
      {
        if (!this.FZero())
          return;
        this.SetPositive();
      }
    }

    public static SqlDecimal AdjustScale(SqlDecimal n, int digits, bool fRound)
    {
      if (n.IsNull)
        return SqlDecimal.Null;
      SqlDecimal sqlDecimal = n;
      sqlDecimal.AdjustScale(digits, fRound);
      return sqlDecimal;
    }

    public static SqlDecimal ConvertToPrecScale(SqlDecimal n, int precision, int scale)
    {
      SqlDecimal.CheckValidPrecScale(precision, scale);
      n.AssertValid();
      if (n.IsNull)
        return SqlDecimal.Null;
      SqlDecimal sqlDecimal = n;
      int digits = scale - (int) sqlDecimal.m_bScale;
      sqlDecimal.AdjustScale(digits, true);
      byte num = SqlDecimal.CLenFromPrec((byte) precision);
      if ((int) num < (int) sqlDecimal.m_bLen)
        throw new SqlTruncateException();
      if ((int) num == (int) sqlDecimal.m_bLen && precision < (int) sqlDecimal.CalculatePrecision())
        throw new SqlTruncateException();
      sqlDecimal.m_bPrec = (byte) precision;
      sqlDecimal.AssertValid();
      return sqlDecimal;
    }

    private int LAbsCmp(SqlDecimal snumOp)
    {
      int bLen1 = (int) snumOp.m_bLen;
      int bLen2 = (int) this.m_bLen;
      if (bLen1 != bLen2)
        return bLen2 <= bLen1 ? -1 : 1;
      uint[] numArray1 = new uint[4]
      {
        this.m_data1,
        this.m_data2,
        this.m_data3,
        this.m_data4
      };
      uint[] numArray2 = new uint[4]
      {
        snumOp.m_data1,
        snumOp.m_data2,
        snumOp.m_data3,
        snumOp.m_data4
      };
      int index = bLen1 - 1;
      while ((int) numArray1[index] == (int) numArray2[index])
      {
        --index;
        if (index < 0)
          return 0;
      }
      return numArray1[index] <= numArray2[index] ? -1 : 1;
    }

    private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD)
    {
      ciulD = ciulS;
      SQLDebug.Check(rgulS.Length >= ciulS, "rgulS.Length >= ciulS", "Invalid array length");
      SQLDebug.Check(rgulD.Length >= ciulS, "rgulD.Length >= ciulS", "Invalid array length");
      for (int index = 0; index < ciulS; ++index)
        rgulD[index] = rgulS[index];
    }

    private static void MpSet(uint[] rgulD, out int ciulD, uint iulN)
    {
      ciulD = 1;
      rgulD[0] = iulN;
    }

    private static void MpNormalize(uint[] rgulU, ref int ciulU)
    {
      while (ciulU > 1 && rgulU[ciulU - 1] == 0U)
        --ciulU;
    }

    private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX)
    {
      SQLDebug.Check(iulX > SqlDecimal.x_uiZero);
      uint num1 = 0;
      int index;
      for (index = 0; index < ciulD; ++index)
      {
        ulong num2 = (ulong) piulD[index];
        ulong x = (ulong) num1 + num2 * (ulong) iulX;
        num1 = SqlDecimal.HI(x);
        piulD[index] = SqlDecimal.LO(x);
      }
      if (num1 == 0U)
        return;
      piulD[index] = num1;
      ++ciulD;
    }

    private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR)
    {
      SQLDebug.Check(rgulU.Length == SqlDecimal.x_cNumeMax);
      uint num1 = 0;
      ulong num2 = (ulong) iulD;
      int index = ciulU;
      SQLDebug.Check(iulD > 0U, "iulD != 0", "Divided by zero!");
      SQLDebug.Check(iulD > 0U, "iulD > 0", "Invalid data: less than zero");
      SQLDebug.Check(ciulU > 0, "ciulU > 0", "No data in the array");
      while (index > 0)
      {
        --index;
        ulong num3 = ((ulong) num1 << 32) + (ulong) rgulU[index];
        rgulU[index] = (uint) (num3 / num2);
        num1 = (uint) (num3 - (ulong) rgulU[index] * num2);
      }
      iulR = num1;
      SqlDecimal.MpNormalize(rgulU, ref ciulU);
    }

    internal static ulong DWL(uint lo, uint hi) => (ulong) lo + ((ulong) hi << 32);

    private static uint HI(ulong x) => (uint) (x >> 32);

    private static uint LO(ulong x) => (uint) x;

    private static void MpDiv(
      uint[] rgulU,
      int ciulU,
      uint[] rgulD,
      int ciulD,
      uint[] rgulQ,
      out int ciulQ,
      uint[] rgulR,
      out int ciulR)
    {
      SQLDebug.Check(ciulU > 0, "ciulU > 0", "In method MpDiv");
      SQLDebug.Check(ciulD > 0, "ciulD > 0", "In method MpDiv");
      SQLDebug.Check(rgulU.Length == SqlDecimal.x_cNumeMax);
      SQLDebug.Check(rgulD.Length == SqlDecimal.x_cNumeMax);
      if (ciulD == 1 && rgulD[0] == 0U)
        ciulQ = ciulR = 0;
      else if (ciulU == 1 && ciulD == 1)
      {
        SqlDecimal.MpSet(rgulQ, out ciulQ, rgulU[0] / rgulD[0]);
        SqlDecimal.MpSet(rgulR, out ciulR, rgulU[0] % rgulD[0]);
      }
      else if (ciulD > ciulU)
      {
        SqlDecimal.MpMove(rgulU, ciulU, rgulR, out ciulR);
        SqlDecimal.MpSet(rgulQ, out ciulQ, 0U);
      }
      else if (ciulU <= 2)
      {
        long num1 = (long) SqlDecimal.DWL(rgulU[0], rgulU[1]);
        ulong num2 = (ulong) rgulD[0];
        if (ciulD > 1)
          num2 += (ulong) rgulD[1] << 32;
        ulong x1 = (ulong) num1 / num2;
        rgulQ[0] = SqlDecimal.LO(x1);
        rgulQ[1] = SqlDecimal.HI(x1);
        ciulQ = SqlDecimal.HI(x1) != 0U ? 2 : 1;
        ulong x2 = (ulong) num1 % num2;
        rgulR[0] = SqlDecimal.LO(x2);
        rgulR[1] = SqlDecimal.HI(x2);
        ciulR = SqlDecimal.HI(x2) != 0U ? 2 : 1;
      }
      else if (ciulD == 1)
      {
        SqlDecimal.MpMove(rgulU, ciulU, rgulQ, out ciulQ);
        uint iulR;
        SqlDecimal.MpDiv1(rgulQ, ref ciulQ, rgulD[0], out iulR);
        rgulR[0] = iulR;
        ciulR = 1;
      }
      else
      {
        ciulQ = ciulR = 0;
        if (rgulU != rgulR)
          SqlDecimal.MpMove(rgulU, ciulU, rgulR, out ciulR);
        ciulQ = ciulU - ciulD + 1;
        uint num1 = rgulD[ciulD - 1];
        rgulR[ciulU] = 0U;
        int index1 = ciulU;
        uint num2 = (uint) (SqlDecimal.x_ulInt32Base / ((ulong) num1 + 1UL));
        if (num2 > 1U)
        {
          SqlDecimal.MpMul1(rgulD, ref ciulD, num2);
          num1 = rgulD[ciulD - 1];
          SqlDecimal.MpMul1(rgulR, ref ciulR, num2);
        }
        uint num3 = rgulD[ciulD - 2];
        do
        {
          ulong num4 = SqlDecimal.DWL(rgulR[index1 - 1], rgulR[index1]);
          uint num5 = (int) num1 != (int) rgulR[index1] ? (uint) (num4 / (ulong) num1) : (uint) (SqlDecimal.x_ulInt32Base - 1UL);
          ulong num6 = (ulong) num5;
          for (uint hi = (uint) (num4 - num6 * (ulong) num1); (ulong) num3 * num6 > SqlDecimal.DWL(rgulR[index1 - 2], hi); num6 = (ulong) num5)
          {
            --num5;
            if (hi < (uint) -(int) num1)
              hi += num1;
            else
              break;
          }
          ulong num7 = SqlDecimal.x_ulInt32Base;
          ulong num8 = 0;
          int index2 = 0;
          int index3 = index1 - ciulD;
          while (index2 < ciulD)
          {
            ulong num9 = (ulong) rgulD[index2];
            ulong x1 = num8 + (ulong) num5 * num9;
            ulong x2 = num7 + ((ulong) rgulR[index3] - (ulong) SqlDecimal.LO(x1));
            num8 = (ulong) SqlDecimal.HI(x1);
            rgulR[index3] = SqlDecimal.LO(x2);
            num7 = (ulong) SqlDecimal.HI(x2) + SqlDecimal.x_ulInt32Base - 1UL;
            ++index2;
            ++index3;
          }
          ulong x3 = num7 + ((ulong) rgulR[index3] - num8);
          rgulR[index3] = SqlDecimal.LO(x3);
          rgulQ[index1 - ciulD] = num5;
          if (SqlDecimal.HI(x3) == 0U)
          {
            rgulQ[index1 - ciulD] = num5 - 1U;
            uint num9 = 0;
            int index4 = 0;
            int index5 = index1 - ciulD;
            while (index4 < ciulD)
            {
              ulong x1 = (ulong) rgulD[index4] + (ulong) rgulR[index5] + (ulong) num9;
              num9 = SqlDecimal.HI(x1);
              rgulR[index5] = SqlDecimal.LO(x1);
              ++index4;
              ++index5;
            }
            rgulR[index5] += num9;
          }
          --index1;
        }
        while (index1 >= ciulD);
        SqlDecimal.MpNormalize(rgulQ, ref ciulQ);
        ciulR = ciulD;
        SqlDecimal.MpNormalize(rgulR, ref ciulR);
        if (num2 <= 1U)
          return;
        uint iulR;
        SqlDecimal.MpDiv1(rgulD, ref ciulD, num2, out iulR);
        SqlDecimal.MpDiv1(rgulR, ref ciulR, num2, out iulR);
      }
    }

    private EComparison CompareNm(SqlDecimal snumOp)
    {
      this.AssertValid();
      snumOp.AssertValid();
      int num1 = this.IsPositive ? 1 : -1;
      int num2 = snumOp.IsPositive ? 1 : -1;
      if (num1 != num2)
        return num1 != 1 ? EComparison.LT : EComparison.GT;
      SqlDecimal sqlDecimal = this;
      SqlDecimal snumOp1 = snumOp;
      int digits = (int) this.m_bScale - (int) snumOp.m_bScale;
      if (digits < 0)
      {
        try
        {
          sqlDecimal.AdjustScale(-digits, true);
        }
        catch (OverflowException ex)
        {
          return num1 > 0 ? EComparison.GT : EComparison.LT;
        }
      }
      else if (digits > 0)
      {
        try
        {
          snumOp1.AdjustScale(digits, true);
        }
        catch (OverflowException ex)
        {
          return num1 > 0 ? EComparison.LT : EComparison.GT;
        }
      }
      int num3 = sqlDecimal.LAbsCmp(snumOp1);
      if (num3 == 0)
        return EComparison.EQ;
      return num1 * num3 < 0 ? EComparison.LT : EComparison.GT;
    }

    private static void CheckValidPrecScale(byte bPrec, byte bScale)
    {
      if (bPrec < (byte) 1 || (int) bPrec > (int) SqlDecimal.MaxPrecision || (bScale < (byte) 0 || (int) bScale > (int) SqlDecimal.MaxScale) || (int) bScale > (int) bPrec)
        throw new SqlTypeException(SQLResource.InvalidPrecScaleMessage);
    }

    private static void CheckValidPrecScale(int iPrec, int iScale)
    {
      if (iPrec < 1 || iPrec > (int) SqlDecimal.MaxPrecision || (iScale < 0 || iScale > (int) SqlDecimal.MaxScale) || iScale > iPrec)
        throw new SqlTypeException(SQLResource.InvalidPrecScaleMessage);
    }

    public static bool? operator ==(SqlDecimal x, SqlDecimal y) => !x.IsNull && !y.IsNull ? new bool?(x.CompareNm(y) == EComparison.EQ) : new bool?();

    public static bool? operator !=(SqlDecimal x, SqlDecimal y)
    {
      bool? nullable = x == y;
      return !nullable.HasValue ? new bool?() : new bool?(!nullable.GetValueOrDefault());
    }

    public static bool? operator <(SqlDecimal x, SqlDecimal y) => !x.IsNull && !y.IsNull ? new bool?(x.CompareNm(y) == EComparison.LT) : new bool?();

    public static bool? operator >(SqlDecimal x, SqlDecimal y) => !x.IsNull && !y.IsNull ? new bool?(x.CompareNm(y) == EComparison.GT) : new bool?();

    public static bool? operator <=(SqlDecimal x, SqlDecimal y)
    {
      if (x.IsNull || y.IsNull)
        return new bool?();
      EComparison ecomparison = x.CompareNm(y);
      return new bool?(ecomparison == EComparison.LT || ecomparison == EComparison.EQ);
    }

    public static bool? operator >=(SqlDecimal x, SqlDecimal y)
    {
      if (x.IsNull || y.IsNull)
        return new bool?();
      EComparison ecomparison = x.CompareNm(y);
      return new bool?(ecomparison == EComparison.GT || ecomparison == EComparison.EQ);
    }

    public static SqlDecimal Add(SqlDecimal x, SqlDecimal y) => x + y;

    public static SqlDecimal Subtract(SqlDecimal x, SqlDecimal y) => x - y;

    public static SqlDecimal Multiply(SqlDecimal x, SqlDecimal y) => x * y;

    public static SqlDecimal Divide(SqlDecimal x, SqlDecimal y) => x / y;

    public static bool? Equals(SqlDecimal x, SqlDecimal y) => x == y;

    public static bool? NotEquals(SqlDecimal x, SqlDecimal y) => x != y;

    public static bool? LessThan(SqlDecimal x, SqlDecimal y) => x < y;

    public static bool? GreaterThan(SqlDecimal x, SqlDecimal y) => x > y;

    public static bool? LessThanOrEqual(SqlDecimal x, SqlDecimal y) => x <= y;

    public static bool? GreaterThanOrEqual(SqlDecimal x, SqlDecimal y) => x >= y;

    private static char ChFromDigit(uint uiDigit)
    {
      SQLDebug.Check(uiDigit < 10U);
      return (char) (uiDigit + 48U);
    }

    private void StoreFromWorkingArray(uint[] rguiData)
    {
      SQLDebug.Check(rguiData.Length == 4);
      this.m_data1 = rguiData[0];
      this.m_data2 = rguiData[1];
      this.m_data3 = rguiData[2];
      this.m_data4 = rguiData[3];
    }

    private void SetToZero()
    {
      SQLDebug.Check(this.m_bPrec >= (byte) 1);
      this.m_bLen = (byte) 1;
      this.m_data1 = this.m_data2 = this.m_data3 = this.m_data4 = 0U;
      this.m_bStatus = (byte) ((uint) SqlDecimal.x_bNotNull | (uint) SqlDecimal.x_bPositive);
      this.AssertValid();
    }

    private void MakeInteger(out bool fFraction)
    {
      int num1 = (int) this.m_bScale;
      fFraction = false;
      while (num1 > 0)
      {
        uint num2;
        if (num1 >= 9)
        {
          num2 = this.DivByULong(SqlDecimal.x_rgulShiftBase[8]);
          num1 -= 9;
        }
        else
        {
          num2 = this.DivByULong(SqlDecimal.x_rgulShiftBase[num1 - 1]);
          num1 = 0;
        }
        if (num2 != 0U)
          fFraction = true;
      }
      this.m_bScale = (byte) 0;
      this.AssertValid();
    }

    public static SqlDecimal Abs(SqlDecimal n)
    {
      n.AssertValid();
      if (n.IsNull)
        return SqlDecimal.Null;
      n.SetPositive();
      n.AssertValid();
      return n;
    }

    public static SqlDecimal Ceiling(SqlDecimal n)
    {
      n.AssertValid();
      if (n.IsNull)
        return SqlDecimal.Null;
      if (n.m_bScale == (byte) 0)
        return n;
      bool fFraction;
      n.MakeInteger(out fFraction);
      if (fFraction && n.IsPositive)
        n.AddULong(1U);
      if (n.FZero())
        n.SetPositive();
      n.AssertValid();
      return n;
    }

    public static SqlDecimal Floor(SqlDecimal n)
    {
      n.AssertValid();
      if (n.IsNull)
        return SqlDecimal.Null;
      if (n.m_bScale == (byte) 0)
        return n;
      bool fFraction;
      n.MakeInteger(out fFraction);
      if (fFraction && !n.IsPositive)
        n.AddULong(1U);
      if (n.FZero())
        n.SetPositive();
      n.AssertValid();
      return n;
    }

    public static int? Sign(SqlDecimal n)
    {
      n.AssertValid();
      if (n.IsNull)
        return new int?();
      if ((n == new SqlDecimal(0)).Value)
        return new int?(0);
      if (n.IsNull)
        return new int?();
      return !n.IsPositive ? new int?(-1) : new int?(1);
    }

    private static SqlDecimal Round(SqlDecimal n, int lPosition, bool fTruncate)
    {
      if (n.IsNull)
        return SqlDecimal.Null;
      if (lPosition >= 0)
      {
        lPosition = Math.Min((int) SqlDecimal.NUMERIC_MAX_PRECISION, lPosition);
        if (lPosition >= (int) n.m_bScale)
          return n;
      }
      else
      {
        lPosition = Math.Max((int) -SqlDecimal.NUMERIC_MAX_PRECISION, lPosition);
        if (lPosition < (int) n.m_bScale - (int) n.m_bPrec)
        {
          n.SetToZero();
          return n;
        }
      }
      uint num1 = 0;
      int num2 = Math.Abs(lPosition - (int) n.m_bScale);
      uint num3 = 1;
      while (num2 > 0)
      {
        if (num2 >= 9)
        {
          num1 = n.DivByULong(SqlDecimal.x_rgulShiftBase[8]);
          num3 = SqlDecimal.x_rgulShiftBase[8];
          num2 -= 9;
        }
        else
        {
          num1 = n.DivByULong(SqlDecimal.x_rgulShiftBase[num2 - 1]);
          num3 = SqlDecimal.x_rgulShiftBase[num2 - 1];
          num2 = 0;
        }
      }
      if (num3 > 1U)
        num1 /= num3 / 10U;
      if (n.FZero() && (fTruncate || num1 < 5U))
      {
        n.SetPositive();
        n.AssertValid();
        return n;
      }
      if (num1 >= 5U && !fTruncate)
        n.AddULong(1U);
      int num4 = Math.Abs(lPosition - (int) n.m_bScale);
      while (num4-- > 0)
        n.MultByULong(SqlDecimal.x_ulBase10);
      n.AssertValid();
      return n;
    }

    public static SqlDecimal Round(SqlDecimal n, int position)
    {
      n.AssertValid();
      return SqlDecimal.Round(n, position, false);
    }

    public static SqlDecimal Truncate(SqlDecimal n, int position)
    {
      n.AssertValid();
      return SqlDecimal.Round(n, position, true);
    }

    public static SqlDecimal Power(SqlDecimal n, double exp)
    {
      n.AssertValid();
      if (n.IsNull)
        return SqlDecimal.Null;
      int precision = (int) n.Precision;
      int scale = (int) n.Scale;
      n = new SqlDecimal(Math.Pow(n.ToDouble(), exp));
      n.AdjustScale(scale - (int) n.Scale, true);
      n.m_bPrec = SqlDecimal.MaxPrecision;
      return n;
    }

    public int CompareTo(object value)
    {
      if (value is SqlDecimal sqlDecimal)
        return this.CompareTo(sqlDecimal);
      throw ADP.WrongType(value.GetType(), typeof (SqlDecimal));
    }

    public int CompareTo(SqlDecimal value)
    {
      if (this.IsNull)
        return !value.IsNull ? -1 : 0;
      if (value.IsNull)
        return 1;
      bool? nullable = this < value;
      if (nullable.Value)
        return -1;
      nullable = this > value;
      return nullable.Value ? 1 : 0;
    }

    public override bool Equals(object value)
    {
      if (!(value is SqlDecimal sqlDecimal))
        return false;
      if (!sqlDecimal.IsNull && !this.IsNull)
        return (this == sqlDecimal).Value;
      return sqlDecimal.IsNull && this.IsNull;
    }

    public override int GetHashCode()
    {
      if (this.IsNull)
        return 0;
      SqlDecimal sqlDecimal = this;
      int precision = (int) sqlDecimal.CalculatePrecision();
      sqlDecimal.AdjustScale((int) SqlDecimal.NUMERIC_MAX_PRECISION - precision, true);
      int bLen = (int) sqlDecimal.m_bLen;
      int num1 = 0;
      int[] data = sqlDecimal.Data;
      for (int index = 0; index < bLen; ++index)
      {
        int num2 = num1 >> 28 & (int) byte.MaxValue;
        num1 = num1 << 4 ^ data[index] ^ num2;
      }
      return num1;
    }
  }
}
