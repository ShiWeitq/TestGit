﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestGitHub
{
    public class Class1
    {
        private string TestFun1()
        {
            //LiQiang add on 2014-02-08
            return "Hello.";
        }

        private int TestFun2()
        {
            //LiQiang add on 2014-02-08
            return 100;
        }

        private string TestFun3()
        {
            //liqiang modify
            return "1243";
        }

        private string TestFun5()
        {
            //shiwei add
            //LiQiang Modify
            return "Hello5.";
        }

        public void TestFun6()
        {
            //LiQiang Add
            int a = 0;
            //shiwei Add
            int b = 0;
        }

        private decimal TestFun7()
        {
            //liqiang add 02/10/2014
            return (decimal)1.234;
        }

        protected string TestMethod1()
        {
            //liqiang add 2014-02/10
            //return string.Empty;
            return "haha123";
        }
        protected string shiwei()
        {
            //shiwei add 2014-02/12
            //return string.Empty;
            return "qq";
        }


        private int LiuhaoTest()
        {
            //liuhao add 2014-02-17
            //return 0;
			return 11;
        }
    }
}
