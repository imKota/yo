using System;
using System.Collections;
using RegExpr;
namespace MyLists
{
    public class TIntegerList: ArrayList
    {
        public int this[int Index]
        {
          get {
            return GetValue(Index);
          }
          set {
            SetValue(Index, value);
          }
        }
        //@ Constructor auto-generated 
        public TIntegerList(Int32 capacity)
            :base(capacity)
        {
        }
        //@ Constructor auto-generated 
        public TIntegerList(ICollection c)
            :base(c)
        {
        }
        // список целых
        // TIntegerList
        public void Add(int v)
        {
        }

        public void Insert(int p, int v)
        {
        }

        //@ Destructor  Destroy()
        ~TIntegerList()
        {
        }
        public int GetValue(int Index)
        {
            int result = 0;
            return result;
        }

        public void SetValue(int Index, int v)
        {
        }

    } // end TIntegerList

    public class TShortIntList: ArrayList
    {
        public sbyte this[int Index]
        {
          get {
            return GetValue(Index);
          }
          set {
            SetValue(Index, value);
          }
        }
        //@ Constructor auto-generated 
        public TShortIntList(Int32 capacity)
            :base(capacity)
        {
        }
        //@ Constructor auto-generated 
        public TShortIntList(ICollection c)
            :base(c)
        {
        }
        // список целых
        // TShortIntList
        public void Add(sbyte v)
        {
        }

        public void Insert(int p, sbyte v)
        {
        }

        //@ Destructor  Destroy()
        ~TShortIntList()
        {
        }
        public sbyte GetValue(int Index)
        {
            sbyte result = 0;
            return result;
        }

        public void SetValue(int Index, sbyte v)
        {
        }

    } // end TShortIntList

    public class TRegExprList: ArrayList
    {
        public TRegExpr this[int Index]
        {
          get {
            return GetValue(Index);
          }
        }
        //@ Constructor auto-generated 
        public TRegExprList(Int32 capacity)
            :base(capacity)
        {
        }
        //@ Constructor auto-generated 
        public TRegExprList(ICollection c)
            :base(c)
        {
        }
        // список регулярных выражений
        // TRegExprList
        public void Add(TRegExpr v)
        {
        }

        //@ Destructor  Destroy()
        ~TRegExprList()
        {
        }
        public TRegExpr GetValue(int Index)
        {
            TRegExpr result = null;
            return result;
        }

    } // end TRegExprList

}

