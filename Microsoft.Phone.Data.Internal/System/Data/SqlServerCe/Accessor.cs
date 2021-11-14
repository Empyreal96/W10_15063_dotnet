// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.Accessor
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Data.SqlServerCe
{
  internal sealed class Accessor : IDisposable
  {
    private object thisLock = new object();
    private bool isFinalized;
    private int index;
    private int count;
    private int bindingIndx;
    private int dataBufferSize;
    private int actualBufferSize;
    private int numValues;
    private IntPtr dataHandle;
    private ulong[] pValueArray;
    private MEDBBINDING[] dbbindings;
    private string[] columnNames;
    internal bool doTruncate;
    internal static readonly Type SByteType = typeof (sbyte);
    internal static readonly Type Int16Type = typeof (short);
    internal static readonly Type Int32Type = typeof (int);
    internal static readonly Type Int64Type = typeof (long);
    internal static readonly Type ByteType = typeof (byte);
    internal static readonly Type SingleType = typeof (float);
    internal static readonly Type DoubleType = typeof (double);
    internal static readonly Type StringType = typeof (string);
    internal static readonly Type GuidType = typeof (Guid);

    static Accessor() => KillBitHelper.ThrowIfKillBitIsSet();

    internal Accessor(int count)
    {
      this.count = count;
      this.dbbindings = new MEDBBINDING[count];
      this.columnNames = new string[count];
      int num1 = 0;
      int num2 = Accessor.AlignDataSize(count * IntPtr.Size);
      int index = 0;
      while (index < count)
      {
        this.dbbindings[index].obSize = num2;
        this.dbbindings[index].obStatus = num1;
        ++index;
        num2 += IntPtr.Size;
        num1 += 4;
      }
      this.dataBufferSize = Accessor.AlignDataSize(num2);
      this.actualBufferSize = this.DataBufferSize;
    }

    ~Accessor() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    [SecuritySafeCritical]
    private void Dispose(bool disposing)
    {
      lock (this.thisLock)
      {
        if (this.isFinalized)
          return;
        if (disposing)
        {
          this.pValueArray = (ulong[]) null;
          this.columnNames = (string[]) null;
        }
        this.ReleaseNativeInterfaces();
        if (disposing)
          return;
        this.isFinalized = true;
      }
    }

    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    [SecurityCritical]
    private void ReleaseNativeInterfaces()
    {
      if (this.dbbindings != null)
      {
        for (int index = 0; index < this.dbbindings.Length; ++index)
        {
          if (IntPtr.Zero != this.dbbindings[index].pObject)
            NativeMethods.CoTaskMemFree(this.dbbindings[index].pObject);
        }
        this.dbbindings = (MEDBBINDING[]) null;
      }
      if (!(IntPtr.Zero != this.dataHandle))
        return;
      NativeMethods.CoTaskMemFree(this.dataHandle);
      this.dataHandle = IntPtr.Zero;
    }

    internal MEDBBINDING[] DbBinding => this.dbbindings;

    internal IntPtr DataHandle => this.dataHandle;

    internal int Count => this.count;

    internal int NumValues
    {
      set => this.numValues = value;
    }

    internal int CurrentIndex
    {
      get => this.index;
      set
      {
        this.index = value;
        this.bindingIndx = this.index % this.count;
      }
    }

    internal int DataBufferSize => this.dataBufferSize;

    internal int ActualDataBufferSize
    {
      set => this.actualBufferSize = value;
    }

    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    [SecurityCritical]
    internal void AllocData()
    {
      Debug.Assert(0 < this.actualBufferSize, "no memory to allocate");
      this.dataHandle = NativeMethods.CoTaskMemAlloc(this.actualBufferSize);
      if (IntPtr.Zero == this.dataHandle)
        throw new OutOfMemoryException();
      NativeMethods.uwutil_ZeroMemory(this.dataHandle, this.actualBufferSize);
      ulong dataHandle = (ulong) (long) this.dataHandle;
      int length = Math.Max(this.count, this.numValues);
      this.pValueArray = new ulong[length];
      for (int index = 0; index < length; ++index)
      {
        ulong num = dataHandle + (ulong) (this.dataBufferSize * (index / this.count));
        this.pValueArray[index] = num;
      }
      GC.KeepAlive((object) this.dataHandle);
    }

    internal int Ordinal
    {
      set => this.dbbindings[this.bindingIndx].iOrdinal = value;
    }

    internal string ColumnName
    {
      get => this.columnNames[this.bindingIndx];
      set => this.columnNames[this.bindingIndx] = value;
    }

    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    internal IntPtr ObjectPtr
    {
      [SecurityCritical] set
      {
        if (IntPtr.Zero != this.dbbindings[this.bindingIndx].pObject)
          NativeMethods.CoTaskMemFree(this.dbbindings[this.bindingIndx].pObject);
        this.dbbindings[this.bindingIndx].pObject = value;
      }
    }

    internal int MaxLen
    {
      get => this.dbbindings[this.bindingIndx].cbMaxLen;
      set
      {
        Debug.Assert(0 <= value, "Accessor: bad DataBufferSize");
        Debug.Assert(IntPtr.Zero == this.dataHandle, "Accessor: dataBuffer already initialized");
        this.dbbindings[this.bindingIndx].obValue = this.dataBufferSize;
        this.dataBufferSize += Accessor.AlignDataSize(value);
        this.actualBufferSize = this.dataBufferSize;
        this.dbbindings[this.bindingIndx].cbMaxLen = value;
      }
    }

    internal SETYPE SeType
    {
      get => this.dbbindings[this.bindingIndx].type;
      set => this.dbbindings[this.bindingIndx].type = value;
    }

    internal byte Precision
    {
      get => (byte) this.dbbindings[this.bindingIndx].bPrecision;
      set => this.dbbindings[this.bindingIndx].bPrecision = (uint) value;
    }

    internal byte Scale
    {
      get => (byte) this.dbbindings[this.bindingIndx].bScale;
      set => this.dbbindings[this.bindingIndx].bScale = (uint) value;
    }

    internal unsafe int SizeValue
    {
      [SecuritySafeCritical] get => *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize);
      [SecuritySafeCritical] set => *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = value;
    }

    internal unsafe DBStatus StatusValue
    {
      [SecuritySafeCritical] get => (DBStatus) *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obStatus);
      [SecuritySafeCritical] set => *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obStatus) = (int) value;
    }

    [SecurityCritical]
    private Exception CheckTypeValueStatusValue(Type type)
    {
      if (this.StatusValue == DBStatus.S_OK)
        return (Exception) new InvalidCastException(Res.GetString("OleDb_CantConvertValue"));
      switch (this.StatusValue)
      {
        case DBStatus.S_OK:
          Debug.Assert(false, "CheckStatusValue: unhandled data with okay status");
          break;
        case DBStatus.E_BADACCESSOR:
          return (Exception) new InvalidOperationException(Res.GetString("OleDb_BadAccessor"));
        case DBStatus.E_CANTCONVERTVALUE:
          return (Exception) new InvalidCastException(Res.GetString("OleDb_CantConvertValue"));
        case DBStatus.S_ISNULL:
          return (Exception) new InvalidCastException();
        case DBStatus.S_TRUNCATED:
          Debug.Assert(false, "CheckStatusValue: Unhandled data with truncated status");
          break;
        case DBStatus.E_SIGNMISMATCH:
          return (Exception) new InvalidOperationException(Res.GetString("OleDb_SignMismatch", (object) type.Name));
        case DBStatus.E_DATAOVERFLOW:
          return (Exception) new InvalidOperationException(Res.GetString("OleDb_DataOverflow", (object) type.Name));
        case DBStatus.E_CANTCREATE:
          return (Exception) new InvalidOperationException(Res.GetString("OleDb_CantCreate", (object) type.Name));
        case DBStatus.E_UNAVAILABLE:
          return (Exception) new InvalidOperationException(Res.GetString("OleDb_Unavailable", (object) type.Name));
        case DBStatus.E_BADSTATUS:
          string minorErrorMessage = NativeMethods.GetMinorErrorMessage(this.dbbindings[this.bindingIndx].minor_pError);
          if (string.IsNullOrEmpty(minorErrorMessage))
            return (Exception) new InvalidOperationException(Res.GetString("OleDb_BadStatus"));
          return (Exception) SqlCeException.CreateException(new SqlCeErrorCollection()
          {
            new SqlCeError(-2147467259, minorErrorMessage, this.dbbindings[this.bindingIndx].minor_pError, "SQL Server Compact ADO.NET Data Provider", 0, 0, 0, (string) null, (string) null, (string) null)
          });
        default:
          return (Exception) new InvalidOperationException(Res.GetString("OleDb_UnexpectedStatusValue", (object) this.StatusValue));
      }
      return (Exception) new InvalidCastException(Res.GetString("OleDb_CantConvertValue"));
    }

    [SecuritySafeCritical]
    internal unsafe void SetValueDBNull()
    {
      this.SizeValue = 0;
      this.StatusValue = DBStatus.S_ISNULL;
      *(long*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue) = 0L;
    }

    [SecuritySafeCritical]
    internal unsafe void SetValueNull()
    {
      this.SizeValue = 0;
      this.StatusValue = DBStatus.S_DEFAULT;
      *(long*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue) = 0L;
    }

    internal unsafe object Value
    {
      [SecuritySafeCritical] get
      {
        switch (this.StatusValue)
        {
          case DBStatus.S_OK:
            switch (this.SeType)
            {
              case SETYPE.TINYINT:
                return (object) *(byte*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.SMALLINT:
                return (object) *(short*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.UI2:
                return (object) *(short*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.INTEGER:
                return (object) *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.UI4:
                return (object) *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.BIGINT:
                return (object) *(long*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.UI8:
                return (object) *(long*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.NCHAR:
                return (object) new string((char*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue));
              case SETYPE.NVARCHAR:
                return (object) new string((char*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue));
              case SETYPE.NTEXT:
                return (object) (IntPtr) (void*) *(IntPtr*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.BINARY:
                return (object) this.Value_BYTES;
              case SETYPE.VARBINARY:
                return (object) this.Value_BYTES;
              case SETYPE.IMAGE:
                return (object) (IntPtr) (void*) *(IntPtr*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.DATETIME:
                return (object) this.Value_DATETIME;
              case SETYPE.UNIQUEIDENTIFIER:
                return (object) this.Value_GUID;
              case SETYPE.BIT:
                return (object) ((uint) *(short*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue) > 0U);
              case SETYPE.REAL:
                return (object) *(float*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.FLOAT:
                return (object) *(double*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
              case SETYPE.MONEY:
                return (object) ((Decimal) *(long*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue) / 10000M);
              case SETYPE.NUMERIC:
                return (object) this.Value_NUMERIC;
              case SETYPE.ROWVERSION:
                return (object) this.Value_BYTES;
              default:
                Debug.Assert(false, "Invalid data type");
                throw new InvalidProgramException("Invalid data type");
            }
          case DBStatus.S_ISNULL:
          case DBStatus.S_DEFAULT:
            return (object) DBNull.Value;
          case DBStatus.S_TRUNCATED:
            switch (this.SeType)
            {
              case SETYPE.NCHAR:
                return (object) new string((char*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue));
              case SETYPE.NVARCHAR:
                return (object) new string((char*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue));
              case SETYPE.NTEXT:
                return (object) new string((char*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue));
              case SETYPE.BINARY:
                return (object) this.Value_BYTES;
              case SETYPE.VARBINARY:
                return (object) this.Value_BYTES;
              case SETYPE.IMAGE:
                return (object) this.Value_BYTES;
              default:
                Debug.Assert(false, "Invalid data type");
                throw new InvalidProgramException("Invalid data type");
            }
          default:
            throw this.CheckTypeValueStatusValue(SqlCeType.FromSeType(this.SeType).clrType);
        }
      }
      [SecuritySafeCritical] set
      {
        if (value == null || value == DBNull.Value || value is INullable && ((INullable) value).IsNull)
        {
          this.SetValueDBNull();
        }
        else
        {
          this.StatusValue = DBStatus.S_OK;
          switch (this.SeType)
          {
            case SETYPE.TINYINT:
              if (value is byte num25)
              {
                this.Value_TINYINT = num25;
                break;
              }
              this.Value_TINYINT = ((IConvertible) value).ToByte((IFormatProvider) null);
              break;
            case SETYPE.SMALLINT:
            case SETYPE.UI2:
              if (value is short num26)
              {
                this.Value_I2 = num26;
                break;
              }
              this.Value_I2 = ((IConvertible) value).ToInt16((IFormatProvider) null);
              break;
            case SETYPE.INTEGER:
            case SETYPE.UI4:
              if (value is int num27)
              {
                this.Value_I4 = num27;
                break;
              }
              this.Value_I4 = ((IConvertible) value).ToInt32((IFormatProvider) null);
              break;
            case SETYPE.BIGINT:
            case SETYPE.UI8:
              if (value is long num28)
              {
                this.Value_I8 = num28;
                break;
              }
              this.Value_I8 = ((IConvertible) value).ToInt64((IFormatProvider) null);
              break;
            case SETYPE.NCHAR:
            case SETYPE.NVARCHAR:
            case SETYPE.NTEXT:
              switch (value)
              {
                case string _:
                  this.Value_STRING = (string) value;
                  return;
                case char[] _:
                  this.Value_CHARS = (char[]) value;
                  return;
                case INullable _:
                  this.Value_STRING = value.ToString();
                  return;
                default:
                  this.Value_STRING = (string) Convert.ChangeType(value, Accessor.StringType, (IFormatProvider) CultureInfo.CurrentCulture);
                  return;
              }
            case SETYPE.BINARY:
            case SETYPE.VARBINARY:
            case SETYPE.IMAGE:
            case SETYPE.ROWVERSION:
              this.Value_BYTES = (byte[]) value;
              break;
            case SETYPE.DATETIME:
              if (value is DateTime dateTime4)
              {
                this.Value_DATETIME = dateTime4;
                break;
              }
              this.Value_DATETIME = ((IConvertible) value).ToDateTime((IFormatProvider) null);
              break;
            case SETYPE.UNIQUEIDENTIFIER:
              switch (value)
              {
                case Guid guid4:
                  this.Value_GUID = guid4;
                  return;
                case string _:
                  this.Value_GUID = new Guid((string) value);
                  return;
                default:
                  this.Value_GUID = (Guid) value;
                  return;
              }
            case SETYPE.BIT:
              if (value is bool flag4)
              {
                this.Value_BOOL = flag4;
                break;
              }
              this.Value_BOOL = ((IConvertible) value).ToBoolean((IFormatProvider) null);
              break;
            case SETYPE.REAL:
              if (value is float num29)
              {
                this.Value_R4 = num29;
                break;
              }
              this.Value_R4 = ((IConvertible) value).ToSingle((IFormatProvider) null);
              break;
            case SETYPE.FLOAT:
              if (value is double num30)
              {
                this.Value_R8 = num30;
                break;
              }
              this.Value_R8 = ((IConvertible) value).ToDouble((IFormatProvider) null);
              break;
            case SETYPE.MONEY:
              switch (value)
              {
                case Decimal num31:
                  this.Value_CY = num31;
                  return;
                case SqlDecimal sqlDecimal7:
                  this.Value_CY = (Decimal) sqlDecimal7;
                  return;
                default:
                  this.Value_CY = ((IConvertible) value).ToDecimal((IFormatProvider) null);
                  return;
              }
            case SETYPE.NUMERIC:
              switch (value)
              {
                case Decimal num32:
                  this.Value_NUMERIC = new SqlDecimal(num32);
                  return;
                case SqlDecimal sqlDecimal8:
                  this.Value_NUMERIC = sqlDecimal8;
                  return;
                default:
                  this.Value_NUMERIC = (SqlDecimal) ((IConvertible) value).ToDecimal((IFormatProvider) null);
                  return;
              }
            default:
              Debug.Assert(false, "Invalid data type");
              break;
          }
        }
      }
    }

    private unsafe bool Value_BOOL
    {
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        *(short*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue) = value ? (short) -1 : (short) 0;
      }
    }

    private unsafe byte[] Value_BYTES
    {
      [SecurityCritical] get
      {
        Debug.Assert(this.StatusValue == DBStatus.S_OK || DBStatus.S_TRUNCATED == this.StatusValue, nameof (Value_BYTES));
        int length = Math.Min(this.SizeValue, this.dbbindings[this.bindingIndx].cbMaxLen);
        byte[] numArray = new byte[length];
        byte* numPtr = (byte*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
        int index = 0;
        while (index < length)
        {
          numArray[index] = *numPtr;
          ++index;
          ++numPtr;
        }
        return numArray;
      }
      [SecurityCritical] set
      {
        if (value == null)
        {
          this.SetValueNull();
        }
        else
        {
          int num = value.Length;
          if (num > this.MaxLen)
          {
            if (this.doTruncate)
              num = this.MaxLen;
            else
              throw new InvalidOperationException(Res.GetString("ADP_TruncatedBytes", (object) this.MaxLen));
          }
          this.SizeValue = num;
          byte* numPtr = (byte*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
          int index = 0;
          while (index < num)
          {
            *numPtr = value[index];
            ++index;
            ++numPtr;
          }
        }
      }
    }

    private unsafe Decimal Value_CY
    {
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        *(long*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue) = (long) (10000M * value);
      }
    }

    private unsafe DateTime Value_DATETIME
    {
      [SecurityCritical] get
      {
        Debug.Assert(this.StatusValue == DBStatus.S_OK, nameof (Value_DATETIME));
        ulong num = (ulong) (UIntPtr) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
        DateTime dateTime = new DateTime((int) *(short*) num, (int) *(short*) (num + 2UL), (int) *(short*) (num + 4UL), (int) *(short*) (num + 6UL), (int) *(short*) (num + 8UL), (int) *(short*) (num + 10UL));
        dateTime = dateTime.AddTicks((long) (*(int*) (num + 12UL) / 100));
        return dateTime;
      }
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        long num;
        *(short*) (num = (long) (ulong) (UIntPtr) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue)) = (short) value.Year;
        *(short*) ((ulong) num + 2UL) = (short) value.Month;
        *(short*) ((ulong) num + 4UL) = (short) value.Day;
        *(short*) ((ulong) num + 6UL) = (short) value.Hour;
        *(short*) ((ulong) num + 8UL) = (short) value.Minute;
        *(short*) ((ulong) num + 10UL) = (short) value.Second;
        *(int*) ((ulong) num + 12UL) = (int) (value.Ticks % 10000000L * 100L);
      }
    }

    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    private unsafe Guid Value_GUID
    {
      [SecurityCritical] get
      {
        Debug.Assert(this.StatusValue == DBStatus.S_OK, nameof (Value_GUID));
        return (Guid) Marshal.PtrToStructure(new IntPtr((void*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue)), Accessor.GuidType);
      }
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        Marshal.StructureToPtr((object) value, new IntPtr((void*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue)), false);
      }
    }

    private unsafe byte Value_TINYINT
    {
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        *(sbyte*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue) = (sbyte) value;
      }
    }

    private unsafe short Value_I2
    {
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        *(short*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue) = value;
      }
    }

    private unsafe int Value_I4
    {
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue) = value;
      }
    }

    private unsafe long Value_I8
    {
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        *(long*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue) = value;
      }
    }

    private unsafe SqlDecimal Value_NUMERIC
    {
      [SecurityCritical] get
      {
        Debug.Assert(this.StatusValue == DBStatus.S_OK, nameof (Value_NUMERIC));
        byte* numPtr1 = (byte*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
        byte* numPtr2 = numPtr1 + 1;
        byte bPrecision = *numPtr1;
        byte* numPtr3 = numPtr2;
        byte* numPtr4 = numPtr3 + 1;
        byte bScale = *numPtr3;
        byte* numPtr5 = numPtr4;
        byte* numPtr6 = numPtr5 + 1;
        byte num = *numPtr5;
        int[] bits = new int[4];
        fixed (int* numPtr7 = &bits[0])
        {
          byte* numPtr8 = (byte*) numPtr7;
          for (int index = 0; index < 16; ++index)
            *numPtr8++ = *numPtr6++;
        }
        bool fPositive = num == (byte) 1;
        return new SqlDecimal(bPrecision, bScale, fPositive, bits);
      }
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        byte num1 = value.IsPositive ? (byte) 1 : (byte) 0;
        int[] data = value.Data;
        byte* numPtr1 = (byte*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
        byte* numPtr2 = numPtr1 + 1;
        int precision = (int) value.Precision;
        *numPtr1 = (byte) precision;
        byte* numPtr3 = numPtr2;
        byte* numPtr4 = numPtr3 + 1;
        int scale = (int) value.Scale;
        *numPtr3 = (byte) scale;
        byte* numPtr5 = numPtr4;
        byte* numPtr6 = numPtr5 + 1;
        int num2 = (int) num1;
        *numPtr5 = (byte) num2;
        fixed (int* numPtr7 = &data[0])
        {
          byte* numPtr8 = (byte*) numPtr7;
          for (int index = 0; index < 16; ++index)
            *numPtr6++ = *numPtr8++;
        }
      }
    }

    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    private unsafe float Value_R4
    {
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        Marshal.StructureToPtr((object) value, new IntPtr((void*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue)), false);
      }
    }

    [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
    private unsafe double Value_R8
    {
      [SecurityCritical] set
      {
        *(int*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obSize) = 0;
        Marshal.StructureToPtr((object) value, new IntPtr((void*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue)), false);
      }
    }

    private unsafe string Value_STRING
    {
      [SecurityCritical] set
      {
        if (value == null)
        {
          this.SetValueNull();
        }
        else
        {
          int num1 = value.Length;
          if (SETYPE.NTEXT != this.dbbindings[this.bindingIndx].type)
          {
            int num2 = this.dbbindings[this.bindingIndx].cbMaxLen / 2 - 1;
            if (num1 > num2)
            {
              if (this.doTruncate)
                num1 = num2;
              else
                throw new InvalidOperationException(Res.GetString("ADP_TruncatedString", (object) num2, (object) num1, (object) value));
            }
          }
          this.SizeValue = (num1 + 1) * 2;
          char* chPtr = (char*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
          int index = 0;
          while (index < num1)
          {
            *chPtr = value[index];
            ++index;
            ++chPtr;
          }
          *chPtr = char.MinValue;
        }
      }
    }

    private unsafe char[] Value_CHARS
    {
      [SecurityCritical] set
      {
        if (value == null)
        {
          this.SetValueNull();
        }
        else
        {
          int num1 = value.Length;
          if (SETYPE.NTEXT != this.dbbindings[this.bindingIndx].type)
          {
            int num2 = this.dbbindings[this.bindingIndx].cbMaxLen / 2 - 1;
            if (num1 > num2)
            {
              if (this.doTruncate)
                num1 = num2;
              else
                throw new InvalidOperationException(Res.GetString("ADP_TruncatedString", (object) num2, (object) num1, (object) value));
            }
          }
          this.SizeValue = (num1 + 1) * 2;
          char* chPtr = (char*) (this.pValueArray[this.index] + (ulong) this.dbbindings[this.bindingIndx].obValue);
          int index = 0;
          while (index < num1)
          {
            *chPtr = value[index];
            ++index;
            ++chPtr;
          }
          *chPtr = char.MinValue;
        }
      }
    }

    private static int AlignDataSize(int value) => value != 0 ? value + 7 & -8 : 8;
  }
}
