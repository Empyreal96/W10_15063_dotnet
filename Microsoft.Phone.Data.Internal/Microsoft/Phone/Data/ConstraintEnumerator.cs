// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ConstraintEnumerator
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Collections;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal class ConstraintEnumerator
  {
    private IEnumerator tables;
    private IEnumerator constraints;
    private Constraint currentObject;

    public ConstraintEnumerator(DataSet dataSet)
    {
      this.tables = dataSet?.Tables.GetEnumerator();
      this.currentObject = (Constraint) null;
    }

    public bool GetNext()
    {
      this.currentObject = (Constraint) null;
      while (this.tables != null)
      {
        if (this.constraints == null)
        {
          if (!this.tables.MoveNext())
          {
            this.tables = (IEnumerator) null;
            return false;
          }
          this.constraints = ((DataTable) this.tables.Current).Constraints.GetEnumerator();
        }
        if (!this.constraints.MoveNext())
        {
          this.constraints = (IEnumerator) null;
        }
        else
        {
          Debug.Assert(this.constraints.Current is Constraint, "ConstraintEnumerator, contains object which is not constraint");
          Constraint current = (Constraint) this.constraints.Current;
          if (this.IsValidCandidate(current))
          {
            this.currentObject = current;
            return true;
          }
        }
      }
      return false;
    }

    public Constraint GetConstraint()
    {
      Debug.Assert(this.currentObject != null, "GetObject should never be called w/ null currentObject.");
      return this.currentObject;
    }

    protected virtual bool IsValidCandidate(Constraint constraint) => true;

    protected Constraint CurrentObject => this.currentObject;
  }
}
