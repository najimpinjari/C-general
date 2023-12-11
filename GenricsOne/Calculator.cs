using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricsOne
{
    public class Calculator
    {
        #region method overloding 
        //public bool AreEqual(int a , int b)
        //{
        //    return a.Equals(b); 
        //}
        //public bool AreEqual(string a, string b)
        //{
        //    return a.Equals(b);
        //}

        #endregion method overloding 

        #region using object type 

        //public bool AreEqual( object a , object b)
        //{
        //    return a.Equals(b);
        //}
        //problem with object typs 
        //1 there is no type sefty 
        //2 chances of boxing and unboxing operations 
        #endregion using object type 

        #region using generics 

        public bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }



        #endregion using generics 

    }
}
