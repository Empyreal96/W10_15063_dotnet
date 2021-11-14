// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeCommandBuilder
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data;
using Microsoft.Phone.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeCommandBuilder : DbCommandBuilder
  {
    private SqlCeRowUpdatingEventHandler _rowUpdatingHandler;

    static SqlCeCommandBuilder() => KillBitHelper.ThrowIfKillBitIsSet();

    public SqlCeCommandBuilder()
    {
      GC.SuppressFinalize((object) this);
      base.QuotePrefix = "[";
      base.QuoteSuffix = "]";
    }

    public SqlCeCommandBuilder(SqlCeDataAdapter adapter)
      : this()
    {
      this.DataAdapter = adapter;
    }

    public override ConflictOption ConflictOption
    {
      get => base.ConflictOption;
      set => base.ConflictOption = value != ConflictOption.CompareAllSearchableValues ? value : throw new NotSupportedException();
    }

    public override CatalogLocation CatalogLocation
    {
      get => CatalogLocation.Start;
      set
      {
        if (CatalogLocation.Start != value)
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, nameof (CatalogLocation)));
      }
    }

    public override string CatalogSeparator
    {
      get => ".";
      set
      {
        if ("." != value)
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, nameof (CatalogSeparator)));
      }
    }

    public SqlCeDataAdapter DataAdapter
    {
      get => (SqlCeDataAdapter) base.DataAdapter;
      set
      {
        SqlCeDataAdapter dataAdapter = (SqlCeDataAdapter) base.DataAdapter;
        if (dataAdapter == value)
          return;
        if (dataAdapter != null)
        {
          dataAdapter.RowUpdating -= this._rowUpdatingHandler;
          this._rowUpdatingHandler = (SqlCeRowUpdatingEventHandler) null;
        }
        Debug.Assert(this._rowUpdatingHandler == null, "handler not clear");
        this.DataAdapter = (DbDataAdapter) value;
      }
    }

    public override string QuotePrefix
    {
      get => base.QuotePrefix;
      set => base.QuotePrefix = !("[" != value) || !("\"" != value) || value.Length == 0 ? value : throw new ArgumentException(Res.GetString("ADP_InvalidQuotePrefix"), string.Format((IFormatProvider) CultureInfo.InvariantCulture, nameof (QuotePrefix)));
    }

    public override string QuoteSuffix
    {
      get => base.QuoteSuffix;
      set => base.QuoteSuffix = !("]" != value) || !("\"" != value) || value.Length == 0 ? value : throw new ArgumentException(Res.GetString("ADP_InvalidQuoteSuffix"), string.Format((IFormatProvider) CultureInfo.InvariantCulture, nameof (QuoteSuffix)));
    }

    public override string SchemaSeparator
    {
      get => ".";
      set
      {
        if ("." != value)
          throw new ArgumentException(Res.GetString("ADP_InvalidSchemaSeparator"), string.Format((IFormatProvider) CultureInfo.InvariantCulture, nameof (SchemaSeparator)));
      }
    }

    private void SqlCeRowUpdatingHandler(object sender, SqlCeRowUpdatingEventArgs ruevent) => this.RowUpdatingHandler((RowUpdatingEventArgs) ruevent);

    public SqlCeCommand GetInsertCommand() => (SqlCeCommand) base.GetInsertCommand();

    public SqlCeCommand GetUpdateCommand() => (SqlCeCommand) base.GetUpdateCommand();

    public SqlCeCommand GetDeleteCommand() => (SqlCeCommand) base.GetDeleteCommand();

    protected override void ApplyParameterInfo(
      DbParameter param,
      DataRow row,
      StatementType statementType,
      bool whereClause)
    {
      SqlCeParameter sqlCeParameter = (SqlCeParameter) param;
      sqlCeParameter.SqlDbType = ((SqlCeType) row["ProviderType"]).SqlDbType;
      sqlCeParameter.IsNullable = (bool) row["AllowDBNull"];
      if (DBNull.Value != row["NumericPrecision"])
        sqlCeParameter.Precision = (byte) (short) row["NumericPrecision"];
      if (DBNull.Value != row["NumericScale"])
        sqlCeParameter.Scale = (byte) (short) row["NumericScale"];
      sqlCeParameter.Size = 0;
    }

    protected override string GetParameterName(int parameterOrdinal) => "@p" + parameterOrdinal.ToString((IFormatProvider) CultureInfo.InvariantCulture);

    protected override string GetParameterName(string parameterName) => "@" + parameterName;

    protected override string GetParameterPlaceholder(int parameterOrdinal) => "@p" + parameterOrdinal.ToString((IFormatProvider) CultureInfo.InvariantCulture);

    protected override void SetRowUpdatingHandler(DbDataAdapter adapter)
    {
      SqlCeDataAdapter sqlCeDataAdapter = (SqlCeDataAdapter) adapter;
      if (sqlCeDataAdapter == null)
        return;
      this._rowUpdatingHandler = new SqlCeRowUpdatingEventHandler(this.SqlCeRowUpdatingHandler);
      sqlCeDataAdapter.RowUpdating += this._rowUpdatingHandler;
    }

    private void ConsistentQuoteDelimiters(string quotePrefix, string quoteSuffix)
    {
      Debug.Assert(quotePrefix == "\"" || quotePrefix == "[");
      if ("\"" == quotePrefix && "\"" != quoteSuffix || "[" == quotePrefix && "]" != quoteSuffix)
        throw new ArgumentException(Res.GetString("ADP_InvalidPrefixSuffix", (object) quotePrefix, (object) quoteSuffix));
    }

    private static string BuildQuotedString(
      string quotePrefix,
      string quoteSuffix,
      string unQuotedString)
    {
      Debug.Assert(unQuotedString != null && "" != unQuotedString, "Unquoted string is either NULL or Empty");
      StringBuilder stringBuilder1 = new StringBuilder();
      if (!ADP.IsEmpty(quotePrefix))
        stringBuilder1.Append(quotePrefix);
      if (!ADP.IsEmpty(quoteSuffix))
      {
        StringBuilder stringBuilder2 = stringBuilder1;
        string str1 = unQuotedString;
        string oldValue = quoteSuffix;
        string str2 = quoteSuffix;
        string newValue = str2 + str2;
        string str3 = str1.Replace(oldValue, newValue);
        stringBuilder2.Append(str3);
        stringBuilder1.Append(quoteSuffix);
      }
      else
        stringBuilder1.Append(unQuotedString);
      return stringBuilder1.ToString();
    }

    private static bool RemoveStringQuotes(
      string quotePrefix,
      string quoteSuffix,
      string quotedString,
      out string unquotedString)
    {
      Debug.Assert(quotedString != null && "" != quotedString, "Quoted string is either NULL or Empty");
      int startIndex = quotePrefix != null ? quotePrefix.Length : 0;
      int num = quoteSuffix != null ? quoteSuffix.Length : 0;
      if (num + startIndex == 0)
      {
        unquotedString = quotedString;
        return true;
      }
      if (quotedString == null)
      {
        unquotedString = quotedString;
        return false;
      }
      int length = quotedString.Length;
      if (length < startIndex + num)
      {
        unquotedString = quotedString;
        return false;
      }
      if (startIndex > 0 && !quotedString.StartsWith(quotePrefix, StringComparison.Ordinal))
      {
        unquotedString = quotedString;
        return false;
      }
      if (num > 0)
      {
        if (!quotedString.EndsWith(quoteSuffix, StringComparison.Ordinal))
        {
          unquotedString = quotedString;
          return false;
        }
        ref string local = ref unquotedString;
        string str1 = quotedString.Substring(startIndex, length - (startIndex + num));
        string str2 = quoteSuffix;
        string oldValue = str2 + str2;
        string newValue = quoteSuffix;
        string str3 = str1.Replace(oldValue, newValue);
        local = str3;
      }
      else
        unquotedString = quotedString.Substring(startIndex, length - startIndex);
      return true;
    }

    public override string QuoteIdentifier(string unquotedIdentifier)
    {
      if (unquotedIdentifier == null)
        throw new ArgumentNullException(nameof (unquotedIdentifier));
      string quoteSuffix = this.QuoteSuffix;
      string quotePrefix = this.QuotePrefix;
      this.ConsistentQuoteDelimiters(quotePrefix, quoteSuffix);
      return SqlCeCommandBuilder.BuildQuotedString(quotePrefix, quoteSuffix, unquotedIdentifier);
    }

    public override string UnquoteIdentifier(string quotedIdentifier)
    {
      if (quotedIdentifier == null)
        throw new ArgumentNullException(nameof (quotedIdentifier));
      string quoteSuffix = this.QuoteSuffix;
      string quotePrefix = this.QuotePrefix;
      this.ConsistentQuoteDelimiters(quotePrefix, quoteSuffix);
      string unquotedString;
      SqlCeCommandBuilder.RemoveStringQuotes(quotePrefix, quoteSuffix, quotedIdentifier, out unquotedString);
      return unquotedString;
    }
  }
}
