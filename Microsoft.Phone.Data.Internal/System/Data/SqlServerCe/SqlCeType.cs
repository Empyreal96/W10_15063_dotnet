// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeType
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using System.Diagnostics;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeType
  {
    internal static readonly SqlCeType _SByte = new SqlCeType((byte) 3, (byte) 0, 1, true, false, SqlDbType.TinyInt, SETYPE.TINYINT, "TinyInt", DbType.SByte, typeof (sbyte));
    internal static readonly SqlCeType _SmallInt = new SqlCeType((byte) 5, (byte) 0, 2, true, false, SqlDbType.SmallInt, SETYPE.SMALLINT, "SmallInt", DbType.Int16, typeof (short));
    internal static readonly SqlCeType _Int = new SqlCeType((byte) 10, (byte) 0, 4, true, false, SqlDbType.Int, SETYPE.INTEGER, "Int", DbType.Int32, typeof (int));
    internal static readonly SqlCeType _BigInt = new SqlCeType((byte) 19, (byte) 0, 8, true, false, SqlDbType.BigInt, SETYPE.BIGINT, "BigInt", DbType.Int64, typeof (long));
    internal static readonly SqlCeType _TinyInt = new SqlCeType((byte) 3, (byte) 0, 1, true, false, SqlDbType.TinyInt, SETYPE.TINYINT, "TinyInt", DbType.Byte, typeof (byte));
    internal static readonly SqlCeType _UInt16 = new SqlCeType((byte) 5, (byte) 0, 2, true, false, SqlDbType.SmallInt, SETYPE.UI2, "SmallInt", DbType.UInt16, typeof (ushort));
    internal static readonly SqlCeType _UInt32 = new SqlCeType((byte) 10, (byte) 0, 4, true, false, SqlDbType.Int, SETYPE.UI4, "Int", DbType.UInt32, typeof (uint));
    internal static readonly SqlCeType _UInt64 = new SqlCeType((byte) 19, (byte) 0, 8, true, false, SqlDbType.BigInt, SETYPE.UI8, "BigInt", DbType.UInt64, typeof (ulong));
    internal static readonly SqlCeType _Real = new SqlCeType((byte) 24, (byte) 0, 4, true, false, SqlDbType.Real, SETYPE.REAL, "Real", DbType.Single, typeof (float));
    internal static readonly SqlCeType _Float = new SqlCeType((byte) 53, (byte) 0, 8, true, false, SqlDbType.Float, SETYPE.FLOAT, "Float", DbType.Double, typeof (double));
    internal static readonly SqlCeType _Money = new SqlCeType((byte) 19, (byte) 4, 8, true, false, SqlDbType.Money, SETYPE.MONEY, "Money", DbType.Currency, typeof (Decimal));
    internal static readonly SqlCeType _Numeric = new SqlCeType((byte) 18, (byte) 0, 19, true, false, SqlDbType.Decimal, SETYPE.NUMERIC, "Numeric", DbType.Decimal, typeof (Decimal));
    internal static readonly SqlCeType _Bit = new SqlCeType((byte) 1, (byte) 0, 2, true, false, SqlDbType.Bit, SETYPE.BIT, "Bit", DbType.Boolean, typeof (bool));
    internal static readonly SqlCeType _UniqueIdentifier = new SqlCeType((byte) 0, (byte) 0, 16, true, false, SqlDbType.UniqueIdentifier, SETYPE.UNIQUEIDENTIFIER, "UniqueIdentifier", DbType.Guid, typeof (Guid));
    internal static readonly SqlCeType _Binary = new SqlCeType((byte) 0, (byte) 0, -1, true, false, SqlDbType.Binary, SETYPE.BINARY, "Binary", DbType.Binary, typeof (byte[]));
    internal static readonly SqlCeType _RowVersion = new SqlCeType((byte) 0, (byte) 0, 8, true, false, SqlDbType.Timestamp, SETYPE.ROWVERSION, "RowVersion", DbType.Binary, typeof (byte[]));
    internal static readonly SqlCeType _Image = new SqlCeType((byte) 0, (byte) 0, -1, false, true, SqlDbType.Image, SETYPE.IMAGE, "Image", DbType.Binary, typeof (byte[]));
    internal static readonly SqlCeType _VarBinary = new SqlCeType((byte) 0, (byte) 0, -1, false, false, SqlDbType.VarBinary, SETYPE.VARBINARY, "VarBinary", DbType.Binary, typeof (byte[]));
    internal static readonly SqlCeType _NText = new SqlCeType((byte) 0, (byte) 0, -1, false, true, SqlDbType.NText, SETYPE.NTEXT, "NText", DbType.String, typeof (string));
    internal static readonly SqlCeType _NChar = new SqlCeType((byte) 0, (byte) 0, -1, true, false, SqlDbType.NChar, SETYPE.NCHAR, "NChar", DbType.StringFixedLength, typeof (string));
    internal static readonly SqlCeType _NVarChar = new SqlCeType((byte) 0, (byte) 0, -1, false, false, SqlDbType.NVarChar, SETYPE.NVARCHAR, "NVarChar", DbType.String, typeof (string));
    internal static readonly SqlCeType _DateTime = new SqlCeType((byte) 23, (byte) 3, 16, true, false, SqlDbType.DateTime, SETYPE.DATETIME, "DateTime", DbType.DateTime, typeof (DateTime));
    internal static readonly SqlCeType Default = SqlCeType._NVarChar;
    internal static SqlCeType.DataTypeAlias[] _aliasTypes;
    internal static readonly SqlCeType[] _AllTypes = new SqlCeType[22]
    {
      SqlCeType._SmallInt,
      SqlCeType._Int,
      SqlCeType._BigInt,
      SqlCeType._TinyInt,
      SqlCeType._Real,
      SqlCeType._Float,
      SqlCeType._Money,
      SqlCeType._Numeric,
      SqlCeType._Bit,
      SqlCeType._UniqueIdentifier,
      SqlCeType._VarBinary,
      SqlCeType._Binary,
      SqlCeType._Image,
      SqlCeType._NVarChar,
      SqlCeType._NText,
      SqlCeType._NChar,
      SqlCeType._DateTime,
      SqlCeType._RowVersion,
      SqlCeType._SByte,
      SqlCeType._UInt16,
      SqlCeType._UInt32,
      SqlCeType._UInt64
    };
    internal static readonly int MAX_BINARY_COLUMN_SIZE = 8000;
    internal static readonly int MAX_IMAGE_COLUMN_SIZE = 1073741823;
    internal static readonly int MAX_NCHAR_COLUMN_SIZE = 4000;
    internal static readonly int MAX_NTEXT_COLUMN_SIZE = 536870911;
    internal readonly SETYPE seType;
    internal readonly string dataType;
    internal readonly Type clrType;
    internal readonly DbType dbType;
    internal readonly SqlDbType sqlDbType;
    internal readonly bool isFixed;
    internal readonly bool isBLOB;
    internal readonly byte maxpre;
    internal readonly byte scale;
    internal readonly int fixlen;
    internal static int[] SqlDbTypeConversionMatrix = new int[24]
    {
      1130341,
      2637954,
      1130341,
      0,
      7184,
      1130341,
      1130341,
      2637954,
      1130341,
      1130341,
      1146743,
      1146743,
      1146743,
      1130341,
      2120834,
      0,
      1130341,
      0,
      0,
      2621570,
      1130341,
      2637954,
      0,
      0
    };

    private static SqlCeType.DataTypeAlias[] _AliasTypes
    {
      get
      {
        if (SqlCeType._aliasTypes == null)
        {
          SqlCeType._aliasTypes = new SqlCeType.DataTypeAlias[2];
          SqlCeType._aliasTypes[0].dataType = "TimeStamp";
          SqlCeType._aliasTypes[0].sqlCeType = SqlCeType._RowVersion;
          SqlCeType._aliasTypes[1].dataType = "Decimal";
          SqlCeType._aliasTypes[1].sqlCeType = SqlCeType._Numeric;
        }
        return SqlCeType._aliasTypes;
      }
    }

    static SqlCeType() => KillBitHelper.ThrowIfKillBitIsSet();

    private SqlCeType(
      byte maxpre,
      byte scale,
      int fixlen,
      bool isFixed,
      bool isBLOB,
      SqlDbType sqlDbType,
      SETYPE seType,
      string dataType,
      DbType dbType,
      Type clrType)
    {
      this.isFixed = isFixed;
      this.isBLOB = isBLOB;
      this.maxpre = maxpre;
      this.scale = scale;
      this.fixlen = fixlen;
      this.sqlDbType = sqlDbType;
      this.seType = seType;
      this.dataType = dataType;
      this.dbType = dbType;
      this.clrType = clrType;
    }

    public SqlDbType SqlDbType => this.sqlDbType;

    internal SETYPE SeType => this.seType;

    internal string DataType => this.dataType;

    internal Type ClrType => this.clrType;

    internal DbType DbType => this.dbType;

    internal bool IsLongValue => this.isBLOB;

    internal bool IsFixed => this.isFixed;

    internal static SqlCeType FromSeType(SETYPE type)
    {
      for (int index = 0; index < SqlCeType._AllTypes.Length; ++index)
      {
        if (type == SqlCeType._AllTypes[index].SeType)
          return SqlCeType._AllTypes[index];
      }
      if (type == SETYPE.INVALID)
        Debug.Assert(false, "Invalid data type");
      else
        Debug.Assert(false, "Unknown data type");
      return SqlCeType._NChar;
    }

    internal static SqlCeType FromDbType(DbType type)
    {
      for (int index = 0; index < SqlCeType._AllTypes.Length; ++index)
      {
        if (type == SqlCeType._AllTypes[index].DbType)
          return SqlCeType._AllTypes[index];
      }
      throw new ArgumentException(Res.GetString("ADP_UnknownDataType", (object) type.ToString(), (object) typeof (SqlDbType).Name));
    }

    internal static SqlCeType FromSqlDbType(SqlDbType type)
    {
      for (int index = 0; index < SqlCeType._AllTypes.Length; ++index)
      {
        if (type == SqlCeType._AllTypes[index].SqlDbType)
          return SqlCeType._AllTypes[index];
      }
      throw new ArgumentException(Res.GetString("ADP_UnknownType", (object) type.ToString(), (object) typeof (SqlDbType).Name));
    }

    internal static SqlCeType FromDataType(string dataType)
    {
      for (int index = 0; index < SqlCeType._AllTypes.Length; ++index)
      {
        if (dataType.Equals(SqlCeType._AllTypes[index].DataType, StringComparison.OrdinalIgnoreCase))
          return SqlCeType._AllTypes[index];
      }
      for (int index = 0; index < SqlCeType._AliasTypes.Length; ++index)
      {
        if (dataType.Equals(SqlCeType._AliasTypes[index].dataType, StringComparison.OrdinalIgnoreCase))
          return SqlCeType._AliasTypes[index].sqlCeType;
      }
      throw new ArgumentException(dataType);
    }

    internal static SqlCeType FromClrType(object value)
    {
      Type type = !(value is Type) ? value.GetType() : (Type) value;
      switch (Type.GetTypeCode(type))
      {
        case TypeCode.Empty:
          throw new ArgumentException(Res.GetString("ADP_InvalidDataType", (object) TypeCode.Empty));
        case TypeCode.Object:
          if (type == typeof (byte[]))
            return SqlCeType._VarBinary;
          if (type == typeof (Guid))
            return SqlCeType._UniqueIdentifier;
          throw new ArgumentException(Res.GetString("ADP_UnknownDataType", (object) type, (object) typeof (SqlCeType).Name));
        case TypeCode.DBNull:
          throw new ArgumentException(Res.GetString("ADP_UnknownDataType", (object) TypeCode.DBNull, (object) typeof (SqlCeType).Name));
        case TypeCode.Boolean:
          return SqlCeType._Bit;
        case TypeCode.Char:
          return SqlCeType._NVarChar;
        case TypeCode.SByte:
          return SqlCeType._SByte;
        case TypeCode.Byte:
          return SqlCeType._TinyInt;
        case TypeCode.Int16:
          return SqlCeType._SmallInt;
        case TypeCode.UInt16:
          return SqlCeType._UInt16;
        case TypeCode.Int32:
          return SqlCeType._Int;
        case TypeCode.UInt32:
          return SqlCeType._UInt32;
        case TypeCode.Int64:
          return SqlCeType._BigInt;
        case TypeCode.UInt64:
          return SqlCeType._UInt64;
        case TypeCode.Single:
          return SqlCeType._Real;
        case TypeCode.Double:
          return SqlCeType._Float;
        case TypeCode.Decimal:
          return SqlCeType._Numeric;
        case TypeCode.DateTime:
          return SqlCeType._DateTime;
        case TypeCode.String:
          return SqlCeType._NVarChar;
        default:
          throw new ArgumentException(Res.GetString("ADP_UnknownDataType", (object) Type.GetTypeCode(type), (object) typeof (SqlCeType).Name));
      }
    }

    public override string ToString() => this.DataType;

    internal static void ValidateDataConversion(SqlDbType expectedType, SqlDbType actualType)
    {
      int index = (int) expectedType;
      if ((1 << (int) (actualType & SqlDbType.Date) & SqlCeType.SqlDbTypeConversionMatrix[index]) == 0)
        throw new ArgumentException(Res.GetString("Expr_DatatypeConvertion", (object) actualType.ToString(), (object) expectedType.ToString()));
    }

    internal struct DataTypeAlias
    {
      public string dataType;
      public SqlCeType sqlCeType;
    }
  }
}
