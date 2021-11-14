// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeParameter
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.SqlTypes;
using System.Globalization;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeParameter : DbParameter, Microsoft.Phone.Data.Workaround.ICloneable
  {
    private byte precision;
    private byte scale;
    private int size;
    private bool designNullable;
    private bool userSpecifiedType;
    private bool userSpecifiedScale;
    private bool valueConverted;
    private bool inferType = true;
    private string parameterName;
    private string sourceColumn;
    private object value;
    private object convertedValue;
    private SqlCeParameterCollection parent;
    private SqlCeType typeMap;
    private DataRowVersion sourceVersion;

    static SqlCeParameter() => KillBitHelper.ThrowIfKillBitIsSet();

    public SqlCeParameter()
    {
      this.inferType = true;
      this.typeMap = SqlCeType.Default;
      this.sourceVersion = DataRowVersion.Current;
    }

    public SqlCeParameter(string name, object value)
      : this()
    {
      this.ParameterName = name;
      this.Value = value;
    }

    public SqlCeParameter(string name, SqlDbType dataType)
      : this()
    {
      this.ParameterName = name;
      this.SqlDbType = dataType;
    }

    public SqlCeParameter(string name, SqlDbType dataType, int size)
      : this()
    {
      this.ParameterName = name;
      this.SqlDbType = dataType;
      this.Size = size;
    }

    public SqlCeParameter(string name, SqlDbType dataType, int size, string sourceColumn)
      : this()
    {
      this.ParameterName = name;
      this.SqlDbType = dataType;
      this.Size = size;
      this.SourceColumn = sourceColumn;
    }

    public SqlCeParameter(
      string parameterName,
      SqlDbType dbType,
      int size,
      bool isNullable,
      byte precision,
      byte scale,
      string sourceColumn,
      DataRowVersion sourceVersion,
      object value)
      : this(parameterName, dbType, size, ParameterDirection.Input, isNullable, precision, scale, sourceColumn, sourceVersion, value)
    {
    }

    public SqlCeParameter(
      string parameterName,
      SqlDbType dbType,
      int size,
      ParameterDirection direction,
      bool isNullable,
      byte precision,
      byte scale,
      string sourceColumn,
      DataRowVersion sourceVersion,
      object value)
    {
      this.ParameterName = parameterName;
      this.SqlDbType = dbType;
      this.Size = size;
      this.Direction = direction;
      this.IsNullable = isNullable;
      this.Precision = precision;
      this.Scale = scale;
      this.SourceColumn = sourceColumn;
      this.SourceVersion = sourceVersion;
      this.Value = value;
    }

    public override DbType DbType
    {
      get => this.typeMap.dbType;
      set
      {
        if (!this.userSpecifiedType || this.typeMap.dbType != value)
        {
          this.BindingChange();
          this.NativeType = SqlCeType.FromDbType(value);
        }
        this.inferType = false;
      }
    }

    public override ParameterDirection Direction
    {
      get => ParameterDirection.Input;
      set
      {
        if (ParameterDirection.Input != value)
          throw new InvalidOperationException(Res.GetString("ADP_InvalidParameterDirection", (object) value, (object) this.ParameterName));
      }
    }

    public override bool IsNullable
    {
      get => this.designNullable;
      set => this.designNullable = value;
    }

    public int Offset
    {
      get => 0;
      set
      {
      }
    }

    public override bool SourceColumnNullMapping
    {
      get => false;
      set
      {
      }
    }

    public SqlDbType SqlDbType
    {
      get => this.typeMap.sqlDbType;
      set
      {
        if (!this.userSpecifiedType || this.typeMap.sqlDbType != value)
        {
          this.BindingChange();
          this.NativeType = SqlCeType.FromSqlDbType(value);
        }
        this.inferType = false;
      }
    }

    internal SqlCeType NativeType
    {
      get => this.typeMap;
      set
      {
        this.typeMap = value;
        this.userSpecifiedType = true;
      }
    }

    internal bool IsUserSpecifiedType => this.userSpecifiedType;

    public override string ParameterName
    {
      get => this.parameterName == null ? string.Empty : this.parameterName;
      set
      {
        int num = 128;
        if (value != null && value.Length > num)
          throw new ArgumentOutOfRangeException(Res.GetString("SQL_InvalidParameterNameLength", (object) value));
        if (string.Compare(value, this.parameterName, CultureInfo.InvariantCulture, CompareOptions.None) == 0)
          return;
        if (this.Parent != null)
          value = this.Parent.OnParameterNameChange(this, value);
        this.parameterName = value;
      }
    }

    internal string InternalParameterName
    {
      get
      {
        if (this.parameterName == null)
          return string.Empty;
        return !this.parameterName.StartsWith("@") ? this.parameterName : this.parameterName.Substring(1);
      }
      set => this.parameterName = value;
    }

    internal SqlCeParameterCollection Parent
    {
      get => this.parent;
      set => this.parent = value;
    }

    public byte Precision
    {
      get
      {
        if (this.precision == (byte) 0 && this.SqlDbType == SqlDbType.Decimal)
        {
          object obj = this.Value;
          if (obj != null && obj != DBNull.Value && (!(obj is INullable) || !((INullable) obj).IsNull))
          {
            switch (obj)
            {
              case Decimal num4:
                sqlDecimal4 = new SqlDecimal(num4);
                goto label_5;
              case SqlDecimal sqlDecimal4:
label_5:
                return sqlDecimal4.Precision;
              default:
                sqlDecimal4 = (SqlDecimal) ((IConvertible) obj).ToDecimal((IFormatProvider) null);
                goto label_5;
            }
          }
        }
        return this.precision;
      }
      set
      {
        if ((int) value > (int) SqlDecimal.MaxPrecision)
          throw new ArgumentOutOfRangeException(Res.GetString("SQL_PrecisionValueOutOfRange", (object) value));
        if ((int) this.precision == (int) value)
          return;
        this.BindingChange();
        this.precision = value;
      }
    }

    public byte Scale
    {
      get
      {
        byte scale = this.scale;
        if (scale == (byte) 0 && this.SqlDbType == SqlDbType.Decimal)
        {
          object obj = this.Value;
          if (obj != null && obj != DBNull.Value && (!(obj is INullable) || !((INullable) obj).IsNull))
          {
            switch (obj)
            {
              case Decimal num4:
                sqlDecimal4 = new SqlDecimal(num4);
                goto label_5;
              case SqlDecimal sqlDecimal4:
label_5:
                scale = sqlDecimal4.Scale;
                break;
              default:
                sqlDecimal4 = (SqlDecimal) ((IConvertible) obj).ToDecimal((IFormatProvider) null);
                goto label_5;
            }
          }
        }
        return scale;
      }
      set
      {
        if ((int) value > (int) this.Precision)
          throw new ArgumentOutOfRangeException(Res.GetString("SqlMisc_InvalidPrecScaleMessage", (object) value));
        if ((int) this.scale != (int) value)
        {
          this.BindingChange();
          this.scale = value;
        }
        this.userSpecifiedScale = true;
      }
    }

    internal int UserSpecifiedSize => this.size;

    public override int Size
    {
      get
      {
        int num = this.size;
        if (num == 0)
          num = this.GetParameterLength();
        return num;
      }
      set
      {
        if (this.size == value)
          return;
        this.BindingChange();
        if (value < 0)
          throw new ArgumentOutOfRangeException(Res.GetString("ADP_InvalidSizeValue", (object) value.ToString((IFormatProvider) CultureInfo.CurrentCulture)));
        int val2 = int.MaxValue;
        switch (this.typeMap.sqlDbType)
        {
          case SqlDbType.BigInt:
            val2 = SqlCeType._BigInt.fixlen;
            break;
          case SqlDbType.Binary:
            val2 = SqlCeType.MAX_BINARY_COLUMN_SIZE;
            break;
          case SqlDbType.Bit:
            val2 = SqlCeType._Bit.fixlen;
            break;
          case SqlDbType.DateTime:
            val2 = SqlCeType._DateTime.fixlen;
            break;
          case SqlDbType.Decimal:
            val2 = SqlCeType._Numeric.fixlen;
            break;
          case SqlDbType.Float:
            val2 = SqlCeType._Float.fixlen;
            break;
          case SqlDbType.Image:
            val2 = SqlCeType.MAX_IMAGE_COLUMN_SIZE;
            break;
          case SqlDbType.Int:
            val2 = SqlCeType._Int.fixlen;
            break;
          case SqlDbType.Money:
            val2 = SqlCeType._Money.fixlen;
            break;
          case SqlDbType.NChar:
            val2 = SqlCeType.MAX_NCHAR_COLUMN_SIZE;
            break;
          case SqlDbType.NText:
            val2 = SqlCeType.MAX_NTEXT_COLUMN_SIZE;
            break;
          case SqlDbType.NVarChar:
            val2 = SqlCeType.MAX_NCHAR_COLUMN_SIZE;
            break;
          case SqlDbType.Real:
            val2 = SqlCeType._Real.fixlen;
            break;
          case SqlDbType.UniqueIdentifier:
            val2 = SqlCeType._UniqueIdentifier.fixlen;
            break;
          case SqlDbType.SmallInt:
            val2 = SqlCeType._SmallInt.fixlen;
            break;
          case SqlDbType.Timestamp:
            val2 = SqlCeType._RowVersion.fixlen;
            break;
          case SqlDbType.TinyInt:
            val2 = SqlCeType._TinyInt.fixlen;
            break;
          case SqlDbType.VarBinary:
            val2 = SqlCeType.MAX_BINARY_COLUMN_SIZE;
            break;
        }
        this.size = Math.Min(value, val2);
      }
    }

    public override string SourceColumn
    {
      get => this.sourceColumn == null ? string.Empty : this.sourceColumn;
      set => this.sourceColumn = value;
    }

    public override DataRowVersion SourceVersion
    {
      get => this.sourceVersion;
      set
      {
        if (value <= DataRowVersion.Current)
        {
          if (value != DataRowVersion.Original && value != DataRowVersion.Current)
            goto label_4;
        }
        else if (value != DataRowVersion.Proposed && value != DataRowVersion.Default)
          goto label_4;
        this.sourceVersion = value;
        return;
label_4:
        throw new ArgumentOutOfRangeException(Res.GetString("ADP_InvalidDataRowVersion", (object) this.ParameterName, (object) value.ToString()));
      }
    }

    public override object Value
    {
      get => this.value;
      set
      {
        if (this.inferType && value != null && !Convert.IsDBNull(value))
          this.typeMap = SqlCeType.FromClrType(value);
        this.valueConverted = false;
        this.convertedValue = (object) null;
        this.value = value;
      }
    }

    public override void ResetDbType()
    {
      this.BindingChange();
      this.NativeType = SqlCeType.Default;
      this.inferType = false;
    }

    private void CopyTo(DbParameter destination)
    {
      SqlCeParameter sqlCeParameter = destination != null ? (SqlCeParameter) destination : throw new NullReferenceException(nameof (destination));
      sqlCeParameter.precision = this.precision;
      sqlCeParameter.scale = this.scale;
      sqlCeParameter.size = this.size;
      sqlCeParameter.designNullable = this.designNullable;
      sqlCeParameter.userSpecifiedType = this.userSpecifiedType;
      sqlCeParameter.userSpecifiedScale = this.userSpecifiedScale;
      sqlCeParameter.valueConverted = this.valueConverted;
      sqlCeParameter.inferType = this.inferType;
      sqlCeParameter.ParameterName = this.ParameterName;
      sqlCeParameter.sourceColumn = this.sourceColumn;
      sqlCeParameter.convertedValue = this.convertedValue;
      sqlCeParameter.parent = (SqlCeParameterCollection) null;
      sqlCeParameter.typeMap = this.typeMap;
      sqlCeParameter.sourceVersion = this.sourceVersion;
      if (this.value is Microsoft.Phone.Data.Workaround.ICloneable)
        sqlCeParameter.value = ((Microsoft.Phone.Data.Workaround.ICloneable) this.value).Clone();
      else
        sqlCeParameter.value = this.value;
    }

    object Microsoft.Phone.Data.Workaround.ICloneable.Clone()
    {
      SqlCeParameter instance = (SqlCeParameter) Activator.CreateInstance(this.GetType());
      this.CopyTo((DbParameter) instance);
      return (object) instance;
    }

    private void BindingChange()
    {
      this.valueConverted = false;
      this.convertedValue = (object) null;
      if (this.parent == null)
        return;
      this.parent.OnDataBindingChange();
    }

    internal int GetParameterLength()
    {
      if (-1 != this.typeMap.fixlen)
        return this.typeMap.fixlen;
      object parameterValue = this.GetParameterValue();
      if (parameterValue == null)
        return 0;
      if (typeof (string) == this.typeMap.clrType)
      {
        if (parameterValue is string)
          return ((string) parameterValue).Length;
      }
      else if (typeof (byte[]) == this.typeMap.clrType && parameterValue is byte[])
        return ((byte[]) parameterValue).Length;
      return 0;
    }

    internal object GetParameterValue()
    {
      if (!this.valueConverted)
      {
        this.convertedValue = this.value;
        if (this.userSpecifiedType && this.value != null)
          this.ConvertValue();
      }
      this.valueConverted = true;
      return this.convertedValue;
    }

    private void ConvertValue()
    {
      if (this.value is DBNull)
        return;
      Type type = this.value.GetType();
      if (type != this.typeMap.clrType && !type.IsArray)
      {
        if (this.value is INullable && ((INullable) this.value).IsNull)
          this.convertedValue = (object) DBNull.Value;
        else if (this.typeMap.clrType == typeof (string))
        {
          this.convertedValue = this.value is IConvertible ? (object) ((IConvertible) this.value).ToString((IFormatProvider) CultureInfo.CurrentCulture) : throw new InvalidCastException(this.ParameterName);
        }
        else
        {
          if (this.typeMap.clrType != typeof (Guid))
            return;
          this.convertedValue = (object) new Guid((string) this.value);
        }
      }
      else
        this.convertedValue = this.value;
    }

    public override string ToString() => this.ParameterName;
  }
}
