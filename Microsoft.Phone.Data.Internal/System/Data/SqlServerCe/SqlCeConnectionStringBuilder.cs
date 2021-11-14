// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeConnectionStringBuilder
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace System.Data.SqlServerCe
{
  public sealed class SqlCeConnectionStringBuilder : DbConnectionStringBuilder
  {
    private static readonly string[] _validKeywords;
    private static readonly Dictionary<string, Keywords> _keywords;
    private int _autoshrinkThreshold = 60;
    private bool _caseSensitive;
    private string _dataSource = "";
    private int _defaultLockEscalation = 100;
    private int _defaultLockTimeout = 2000;
    private bool _encrypt;
    private string _encryptionMode;
    private bool _enlist = true;
    private string _fileMode = "Read Write";
    private int _flushInterval = 10;
    private int _initialLcid = -1;
    private int _maxBufferSize = 384;
    private int _maxDatabaseSize = 32;
    private string _password = "";
    private bool _persistSecurityInfo;
    private int _tempFileMaxSize = 32;
    private string _tempFilePath;
    private string _connectionString;
    private Dictionary<int, bool> _isDirty;
    private static Regex _connectionStringQuoteValueRegex = new Regex("^[^\"'=;\\s\\p{Cc}]*$");

    static SqlCeConnectionStringBuilder()
    {
      SqlCeConnectionStringBuilder._validKeywords = KeywordMapper.ValidKeywords;
      SqlCeConnectionStringBuilder._keywords = KeywordMapper.KeywordsDictionary;
    }

    public SqlCeConnectionStringBuilder()
      : this((string) null)
    {
    }

    public SqlCeConnectionStringBuilder(string connectionString)
    {
      this.InitializeDirtyFlags();
      if (ADP.IsEmpty(connectionString))
        return;
      this.ConnectionString = connectionString;
    }

    public override bool Remove(string keyword)
    {
      ADP.CheckArgumentNull((object) keyword, nameof (keyword));
      Keywords index;
      if (!SqlCeConnectionStringBuilder._keywords.TryGetValue(keyword, out index))
        return false;
      this.Reset(index);
      return true;
    }

    public override object this[string keyword]
    {
      get => this.GetAt(SqlCeConnectionStringBuilder.GetIndex(keyword));
      set
      {
        if (value != null)
        {
          switch (SqlCeConnectionStringBuilder.GetIndex(keyword))
          {
            case Keywords.AutoshrinkThreshold:
              this.AutoshrinkThreshold = SqlCeConnectionStringBuilder.ConvertToInt32(value);
              break;
            case Keywords.CaseSensitive:
              this.CaseSensitive = SqlCeConnectionStringBuilder.ConvertToBoolean(value);
              break;
            case Keywords.DataSource:
              this.DataSource = SqlCeConnectionStringBuilder.ConvertToString(value);
              break;
            case Keywords.DefaultLockEscalation:
              this.DefaultLockEscalation = SqlCeConnectionStringBuilder.ConvertToInt32(value);
              break;
            case Keywords.DefaultLockTimeout:
              this.DefaultLockTimeout = SqlCeConnectionStringBuilder.ConvertToInt32(value);
              break;
            case Keywords.Encrypt:
              this.Encrypt = SqlCeConnectionStringBuilder.ConvertToBoolean(value);
              break;
            case Keywords.EncryptionMode:
              this.EncryptionMode = SqlCeConnectionStringBuilder.ConvertToString(value);
              break;
            case Keywords.Enlist:
              this.Enlist = SqlCeConnectionStringBuilder.ConvertToBoolean(value);
              break;
            case Keywords.FileMode:
              this.FileMode = SqlCeConnectionStringBuilder.ConvertToString(value);
              break;
            case Keywords.FlushInterval:
              this.FlushInterval = SqlCeConnectionStringBuilder.ConvertToInt32(value);
              break;
            case Keywords.InitialLcid:
              this.InitialLcid = SqlCeConnectionStringBuilder.ConvertToInt32(value);
              break;
            case Keywords.MaxBufferSize:
              this.MaxBufferSize = SqlCeConnectionStringBuilder.ConvertToInt32(value);
              break;
            case Keywords.MaxDatabaseSize:
              this.MaxDatabaseSize = SqlCeConnectionStringBuilder.ConvertToInt32(value);
              break;
            case Keywords.Password:
              this.Password = SqlCeConnectionStringBuilder.ConvertToString(value);
              break;
            case Keywords.PersistSecurityInfo:
              this.PersistSecurityInfo = SqlCeConnectionStringBuilder.ConvertToBoolean(value);
              break;
            case Keywords.TempFileMaxSize:
              this.TempFileMaxSize = SqlCeConnectionStringBuilder.ConvertToInt32(value);
              break;
            case Keywords.TempFilePath:
              this.TempFilePath = SqlCeConnectionStringBuilder.ConvertToString(value);
              break;
            default:
              throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "ADP_KeywordNotSupported", (object) keyword));
          }
        }
        else
          this.Remove(keyword);
      }
    }

    public int AutoshrinkThreshold
    {
      get => this._autoshrinkThreshold;
      set
      {
        if (0 > value || 100 < value)
          throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ArgumentOutOfRange", (object) "Autoshrink Threshold", (object) 0, (object) 100));
        this.SetValue("Autoshrink Threshold", value);
        this._autoshrinkThreshold = value;
      }
    }

    public bool CaseSensitive
    {
      get => this._caseSensitive;
      set
      {
        this.SetValue("Case Sensitive", value);
        this._caseSensitive = value;
      }
    }

    public string DataSource
    {
      get => this._dataSource;
      set
      {
        this.SetValue("Data Source", value);
        this._dataSource = value;
      }
    }

    public int DefaultLockEscalation
    {
      get => this._defaultLockEscalation;
      set
      {
        if (50 > value)
          throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ArgumentOutOfRange", (object) "Default Lock Escalation", (object) 50, (object) int.MaxValue));
        this.SetValue("Default Lock Escalation", value);
        this._defaultLockEscalation = value;
      }
    }

    public int DefaultLockTimeout
    {
      get => this._defaultLockTimeout;
      set
      {
        if (0 > value)
          throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ArgumentOutOfRange", (object) "Default Lock Timeout", (object) 0, (object) int.MaxValue));
        this.SetValue("Default Lock Timeout", value);
        this._defaultLockTimeout = value;
      }
    }

    public bool Encrypt
    {
      get => this._encrypt;
      set
      {
        this.SetValue("Encrypt Database", value);
        this._encrypt = value;
      }
    }

    public string EncryptionMode
    {
      get => this._encryptionMode;
      set
      {
        if (value.Equals("Engine Default", StringComparison.OrdinalIgnoreCase))
          value = "Engine Default";
        else
          value = value.Equals("Platform Default", StringComparison.OrdinalIgnoreCase) ? "Platform Default" : throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQL_InvalidConnectionOptionValue", (object) "Encryption Mode", (object) value));
        this.SetValue("Encryption Mode", value);
        this._encryptionMode = value;
      }
    }

    public bool Enlist
    {
      get => this._enlist;
      set
      {
        this.SetValue(nameof (Enlist), value);
        this._enlist = value;
      }
    }

    public string FileMode
    {
      get => this._fileMode;
      set
      {
        if (value.Equals("Read Only", StringComparison.OrdinalIgnoreCase))
          value = "Read Only";
        else if (value.Equals("Read Write", StringComparison.OrdinalIgnoreCase))
          value = "Read Write";
        else if (value.Equals("Shared Read", StringComparison.OrdinalIgnoreCase))
          value = "Shared Read";
        else
          value = value.Equals("Exclusive", StringComparison.OrdinalIgnoreCase) ? "Exclusive" : throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQL_InvalidConnectionOptionValue", (object) "Mode", (object) value));
        this.SetValue("Mode", value);
        this._fileMode = value;
      }
    }

    public int FlushInterval
    {
      get => this._flushInterval;
      set
      {
        if (1 > value || 1000 < value)
          throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ArgumentOutOfRange", (object) "Flush Interval", (object) 1, (object) 1000));
        this.SetValue("Flush Interval", value);
        this._flushInterval = value;
      }
    }

    public int InitialLcid
    {
      get => this._initialLcid;
      set
      {
        if (value < 0)
          throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ArgumentOutOfRange", (object) "Locale Identifier", (object) 0, (object) int.MaxValue));
        this.SetValue("Locale Identifier", value);
        this._initialLcid = value;
      }
    }

    public int MaxBufferSize
    {
      get => this._maxBufferSize;
      set
      {
        if (256 > value || 5120 < value)
          throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ArgumentOutOfRange", (object) "Max Buffer Size", (object) 256, (object) 5120));
        this.SetValue("Max Buffer Size", value);
        this._maxBufferSize = value;
      }
    }

    public int MaxDatabaseSize
    {
      get => this._maxDatabaseSize;
      set
      {
        if (16 > value || 512 < value)
          throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ArgumentOutOfRange", (object) "Max Database Size", (object) 16, (object) 512));
        this.SetValue("Max Database Size", value);
        this._maxDatabaseSize = value;
      }
    }

    public string Password
    {
      get => this._password;
      set
      {
        this.SetValue(nameof (Password), value);
        this._password = value;
      }
    }

    public bool PersistSecurityInfo
    {
      get => this._persistSecurityInfo;
      set
      {
        this.SetValue("Persist Security Info", value);
        this._persistSecurityInfo = value;
      }
    }

    public int TempFileMaxSize
    {
      get => this._tempFileMaxSize;
      set
      {
        if (16 > value || 512 < value)
          throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ArgumentOutOfRange", (object) "Temp File Max Size", (object) 16, (object) 512));
        this.SetValue("Temp File Max Size", value);
        this._tempFileMaxSize = value;
      }
    }

    public string TempFilePath
    {
      get => this._tempFilePath;
      set
      {
        this.SetValue("Temp File Directory", value);
        this._tempFilePath = value;
      }
    }

    public override ICollection Keys => (ICollection) new ReadOnlyCollection<string>((IList<string>) SqlCeConnectionStringBuilder._validKeywords);

    public override ICollection Values
    {
      get
      {
        object[] objArray = new object[SqlCeConnectionStringBuilder._validKeywords.Length];
        for (int index = 0; index < objArray.Length; ++index)
          objArray[index] = this.GetAt((Keywords) index);
        return (ICollection) new ReadOnlyCollection<object>((IList<object>) objArray);
      }
    }

    public new string ConnectionString
    {
      get
      {
        string connectionString = this._connectionString;
        if (connectionString == null)
        {
          StringBuilder builder = new StringBuilder();
          foreach (string key in (IEnumerable) this.Keys)
          {
            if (this.IsDirty(key))
              this.AppendKeyValuePair(builder, key, this[key].ToString());
          }
          connectionString = builder.ToString();
          this._connectionString = connectionString;
        }
        return connectionString;
      }
      set
      {
        string connectionString = this._connectionString;
        try
        {
          foreach (KeyValuePair<string, string> keyValuePair in ConStringUtil.ParseConnectionString(value))
          {
            if (keyValuePair.Value != null)
              this[keyValuePair.Key] = (object) keyValuePair.Value;
          }
          this._connectionString = (string) null;
        }
        catch (ArgumentException ex)
        {
          this.ConnectionString = connectionString;
          throw;
        }
      }
    }

    internal string OledbConnectionString => ConStringUtil.MapToOledbConnectionString(this.ConnectionString);

    private static bool ConvertToBoolean(object value)
    {
      Debug.Assert(value != null, "ConvertToBoolean(null)");
      if (value is bool flag)
        return flag;
      string x = (value as string).Trim();
      if (x != null)
      {
        if (StringComparer.OrdinalIgnoreCase.Equals(x, "true") || StringComparer.OrdinalIgnoreCase.Equals(x, "yes"))
          return true;
        return !StringComparer.OrdinalIgnoreCase.Equals(x, "false") && !StringComparer.OrdinalIgnoreCase.Equals(x, "no") && bool.Parse(x);
      }
      try
      {
        return ((IConvertible) value).ToBoolean((IFormatProvider) CultureInfo.InvariantCulture);
      }
      catch (InvalidCastException ex)
      {
        throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ConvertFailed", (object) value.GetType(), (object) typeof (bool)), (Exception) ex);
      }
    }

    private static int ConvertToInt32(object value)
    {
      try
      {
        return ((IConvertible) value).ToInt32((IFormatProvider) CultureInfo.InvariantCulture);
      }
      catch (InvalidCastException ex)
      {
        throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ConvertFailed", (object) value.GetType(), (object) typeof (int)), (Exception) ex);
      }
    }

    private static string ConvertToString(object value)
    {
      try
      {
        return ((IConvertible) value).ToString((IFormatProvider) CultureInfo.InvariantCulture);
      }
      catch (InvalidCastException ex)
      {
        throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "SQLCE_ConvertFailed", (object) value.GetType(), (object) typeof (string)), (Exception) ex);
      }
    }

    private object GetAt(Keywords index)
    {
      switch (index)
      {
        case Keywords.AutoshrinkThreshold:
          return (object) this.AutoshrinkThreshold;
        case Keywords.CaseSensitive:
          return (object) this.CaseSensitive;
        case Keywords.DataSource:
          return (object) this.DataSource;
        case Keywords.DefaultLockEscalation:
          return (object) this.DefaultLockEscalation;
        case Keywords.DefaultLockTimeout:
          return (object) this.DefaultLockTimeout;
        case Keywords.Encrypt:
          return (object) this.Encrypt;
        case Keywords.EncryptionMode:
          return (object) this.EncryptionMode;
        case Keywords.Enlist:
          return (object) this.Enlist;
        case Keywords.FileMode:
          return (object) this.FileMode;
        case Keywords.FlushInterval:
          return (object) this.FlushInterval;
        case Keywords.InitialLcid:
          return (object) this.InitialLcid;
        case Keywords.MaxBufferSize:
          return (object) this.MaxBufferSize;
        case Keywords.MaxDatabaseSize:
          return (object) this.MaxDatabaseSize;
        case Keywords.Password:
          return (object) this.Password;
        case Keywords.PersistSecurityInfo:
          return (object) this.PersistSecurityInfo;
        case Keywords.TempFileMaxSize:
          return (object) this.TempFileMaxSize;
        case Keywords.TempFilePath:
          return (object) this.TempFilePath;
        default:
          throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "ADP_KeywordNotSupported", (object) SqlCeConnectionStringBuilder._validKeywords[(int) index]));
      }
    }

    private static Keywords GetIndex(string keyword)
    {
      ADP.CheckArgumentNull((object) keyword, nameof (keyword));
      Keywords keywords;
      if (SqlCeConnectionStringBuilder._keywords.TryGetValue(keyword, out keywords))
        return keywords;
      throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "ADP_KeywordNotSupported", (object) keyword));
    }

    private void Reset(Keywords index)
    {
      switch (index)
      {
        case Keywords.AutoshrinkThreshold:
          this._autoshrinkThreshold = 60;
          break;
        case Keywords.CaseSensitive:
          this._caseSensitive = false;
          break;
        case Keywords.DataSource:
          this._dataSource = "";
          break;
        case Keywords.DefaultLockEscalation:
          this._defaultLockEscalation = 100;
          break;
        case Keywords.DefaultLockTimeout:
          this._defaultLockTimeout = 2000;
          break;
        case Keywords.Encrypt:
          this._encrypt = false;
          break;
        case Keywords.EncryptionMode:
          this._encryptionMode = (string) null;
          break;
        case Keywords.Enlist:
          this._enlist = true;
          break;
        case Keywords.FileMode:
          this._fileMode = "Read Write";
          break;
        case Keywords.FlushInterval:
          this._flushInterval = 10;
          break;
        case Keywords.InitialLcid:
          this._initialLcid = -1;
          break;
        case Keywords.MaxBufferSize:
          this._maxBufferSize = 384;
          break;
        case Keywords.MaxDatabaseSize:
          this._maxDatabaseSize = 32;
          break;
        case Keywords.Password:
          this._password = "";
          break;
        case Keywords.PersistSecurityInfo:
          this._persistSecurityInfo = false;
          break;
        case Keywords.TempFileMaxSize:
          this._tempFileMaxSize = 32;
          break;
        case Keywords.TempFilePath:
          this._tempFilePath = (string) null;
          break;
        default:
          throw new ArgumentException(Res.GetString(CultureInfo.CurrentCulture, "ADP_KeywordNotSupported", (object) SqlCeConnectionStringBuilder._validKeywords[(int) index]));
      }
      this._isDirty[(int) index] = false;
    }

    private void SetValue(string keyword, bool value)
    {
      this.SetDirtyFlag(keyword);
      this._connectionString = (string) null;
    }

    private void SetValue(string keyword, int value)
    {
      this.SetDirtyFlag(keyword);
      this._connectionString = (string) null;
    }

    private void SetValue(string keyword, string value)
    {
      this.SetDirtyFlag(keyword);
      this._connectionString = (string) null;
    }

    private void SetDirtyFlag(string keyword)
    {
      ADP.CheckArgumentNull((object) keyword, nameof (keyword));
      Keywords keywords;
      if (!SqlCeConnectionStringBuilder._keywords.TryGetValue(keyword, out keywords))
        return;
      this._isDirty[(int) keywords] = true;
    }

    private bool IsDirty(string keyword)
    {
      ADP.CheckArgumentNull((object) keyword, nameof (keyword));
      Keywords keywords;
      return SqlCeConnectionStringBuilder._keywords.TryGetValue(keyword, out keywords) && this._isDirty[(int) keywords];
    }

    private void InitializeDirtyFlags()
    {
      this._isDirty = new Dictionary<int, bool>(17);
      for (int key = 0; key < 17; ++key)
        this._isDirty.Add(key, false);
    }

    private void AppendKeyValuePair(StringBuilder builder, string keyName, string keyValue)
    {
      if (0 < builder.Length)
      {
        StringBuilder stringBuilder = builder;
        if (';' != stringBuilder[stringBuilder.Length - 1])
          builder.Append(";");
      }
      builder.Append(keyName.Replace("=", "=="));
      builder.Append("=");
      if (keyValue == null)
        return;
      if (SqlCeConnectionStringBuilder._connectionStringQuoteValueRegex.IsMatch(keyValue))
        builder.Append(keyValue);
      else if (-1 != keyValue.IndexOf('"') && -1 == keyValue.IndexOf('\''))
      {
        builder.Append('\'');
        builder.Append(keyValue);
        builder.Append('\'');
      }
      else
      {
        builder.Append('"');
        builder.Append(keyValue.Replace("\"", "\"\""));
        builder.Append('"');
      }
    }
  }
}
