namespace UnitTest
{
    using NUnit.Framework;
    using System;
    using LearnIt.DateFormater;
    using LearnIt.Validation;

    [TestFixture]
    public class LearnItTest
    { 
        [Test]
        public void Test_DateFormater_FormatMethod()
        {
            
            DateTime d;

            /*  TEST Days  */
            d = new DateTime(1, 1, 01);
            Assert.AreEqual("01 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 02);
            Assert.AreEqual("02 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 03);
            Assert.AreEqual("03 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 04);
            Assert.AreEqual("04 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 05);
            Assert.AreEqual("05 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 06);
            Assert.AreEqual("06 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 07);
            Assert.AreEqual("07 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 08);
            Assert.AreEqual("08 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 09);
            Assert.AreEqual("09 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 10);
            Assert.AreEqual("10 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 11);
            Assert.AreEqual("11 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 12);
            Assert.AreEqual("12 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 13);
            Assert.AreEqual("13 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 14);
            Assert.AreEqual("14 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 15);
            Assert.AreEqual("15 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 16);
            Assert.AreEqual("16 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 17);
            Assert.AreEqual("17 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 18);
            Assert.AreEqual("18 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 19);
            Assert.AreEqual("19 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 20);
            Assert.AreEqual("20 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 21);
            Assert.AreEqual("21 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 22);
            Assert.AreEqual("22 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 23);
            Assert.AreEqual("23 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 24);
            Assert.AreEqual("24 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 25);
            Assert.AreEqual("25 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 26);
            Assert.AreEqual("26 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 27);
            Assert.AreEqual("27 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 28);
            Assert.AreEqual("28 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 29);
            Assert.AreEqual("29 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 30);
            Assert.AreEqual("30 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 1, 31);
            Assert.AreEqual("31 Jan 0001", DateFormater.Format(d));


            /*  TEST Months  */
            d = new DateTime(1, 01, 1);
            Assert.AreEqual("01 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1, 02, 1);
            Assert.AreEqual("01 Feb 0001", DateFormater.Format(d));
            d = new DateTime(1, 03, 1);
            Assert.AreEqual("01 Mar 0001", DateFormater.Format(d));
            d = new DateTime(1, 04, 1);
            Assert.AreEqual("01 Apr 0001", DateFormater.Format(d));
            d = new DateTime(1, 05, 1);
            Assert.AreEqual("01 May 0001", DateFormater.Format(d));
            d = new DateTime(1, 06, 1);
            Assert.AreEqual("01 Jun 0001", DateFormater.Format(d));
            d = new DateTime(1, 07, 1);
            Assert.AreEqual("01 Jul 0001", DateFormater.Format(d));
            d = new DateTime(1, 08, 1);
            Assert.AreEqual("01 Aug 0001", DateFormater.Format(d));
            d = new DateTime(1, 09, 1);
            Assert.AreEqual("01 Sep 0001", DateFormater.Format(d));
            d = new DateTime(1, 10, 1);
            Assert.AreEqual("01 Oct 0001", DateFormater.Format(d));
            d = new DateTime(1, 11, 1);
            Assert.AreEqual("01 Nov 0001", DateFormater.Format(d));
            d = new DateTime(1, 12, 1);
            Assert.AreEqual("01 Dec 0001", DateFormater.Format(d));


            /*  TEST Years  */
            d = new DateTime(0001, 1, 1);
            Assert.AreEqual("01 Jan 0001", DateFormater.Format(d));
            d = new DateTime(1212, 1, 1);
            Assert.AreEqual("01 Jan 1212", DateFormater.Format(d));
            d = new DateTime(7543, 1, 1);
            Assert.AreEqual("01 Jan 7543", DateFormater.Format(d));
            d = new DateTime(2010, 1, 1);
            Assert.AreEqual("01 Jan 2010", DateFormater.Format(d));
            d = new DateTime(1879, 1, 1);
            Assert.AreEqual("01 Jan 1879", DateFormater.Format(d));
            d = new DateTime(1497, 1, 1);
            Assert.AreEqual("01 Jan 1497", DateFormater.Format(d));
            d = new DateTime(1087, 1, 1);
            Assert.AreEqual("01 Jan 1087", DateFormater.Format(d));
            d = new DateTime(2045, 1, 1);
            Assert.AreEqual("01 Jan 2045", DateFormater.Format(d));
            d = new DateTime(3413, 1, 1);
            Assert.AreEqual("01 Jan 3413", DateFormater.Format(d));
        }

        [Test]
        public void Test_DateFormater_InputStyleMethod()
        {
            DateTime d;

            /*  TEST Days  */
            d = new DateTime(01, 01, 01);
            Assert.AreEqual("0001-01-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 01, 26);
            Assert.AreEqual("0001-01-26", DateFormater.InputStyle(d));
            d = new DateTime(01, 01, 15);
            Assert.AreEqual("0001-01-15", DateFormater.InputStyle(d));
            d = new DateTime(01, 01, 31);
            Assert.AreEqual("0001-01-31", DateFormater.InputStyle(d));
            d = new DateTime(01, 01, 05);
            Assert.AreEqual("0001-01-05", DateFormater.InputStyle(d));
            d = new DateTime(01, 01, 11);
            Assert.AreEqual("0001-01-11", DateFormater.InputStyle(d));
            d = new DateTime(01, 01, 19);
            Assert.AreEqual("0001-01-19", DateFormater.InputStyle(d));
            d = new DateTime(01, 01, 21);
            Assert.AreEqual("0001-01-21", DateFormater.InputStyle(d));

            /*  TEST Months  */
            d = new DateTime(01, 01, 01);
            Assert.AreEqual("0001-01-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 02, 01);
            Assert.AreEqual("0001-02-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 03, 01);
            Assert.AreEqual("0001-03-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 04, 01);
            Assert.AreEqual("0001-04-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 05, 01);
            Assert.AreEqual("0001-05-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 06, 01);
            Assert.AreEqual("0001-06-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 07, 01);
            Assert.AreEqual("0001-07-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 08, 01);
            Assert.AreEqual("0001-08-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 09, 01);
            Assert.AreEqual("0001-09-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 10, 01);
            Assert.AreEqual("0001-10-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 11, 01);
            Assert.AreEqual("0001-11-01", DateFormater.InputStyle(d));
            d = new DateTime(01, 12, 01);
            Assert.AreEqual("0001-12-01", DateFormater.InputStyle(d));

            /*  TEST Years  */
            d = new DateTime(01, 01, 01);
            Assert.AreEqual("0001-01-01", DateFormater.InputStyle(d));
            d = new DateTime(2323, 01, 01);
            Assert.AreEqual("2323-01-01", DateFormater.InputStyle(d));
            d = new DateTime(1065, 01, 01);
            Assert.AreEqual("1065-01-01", DateFormater.InputStyle(d));
            d = new DateTime(1686, 01, 01);
            Assert.AreEqual("1686-01-01", DateFormater.InputStyle(d));
            d = new DateTime(2010, 01, 01);
            Assert.AreEqual("2010-01-01", DateFormater.InputStyle(d));
            d = new DateTime(5456, 01, 01);
            Assert.AreEqual("5456-01-01", DateFormater.InputStyle(d));
            d = new DateTime(1987, 01, 01);
            Assert.AreEqual("1987-01-01", DateFormater.InputStyle(d));
            d = new DateTime(2001, 01, 01);
            Assert.AreEqual("2001-01-01", DateFormater.InputStyle(d));
        }

        [Test]
        public void Test_InputValidator_IsOnlyFromLettersAndSpacesMethod()
        {
            string s;

            s = "";
            Assert.AreEqual(true, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "fgsdhsd sdhrsrthrhtr";
            Assert.AreEqual(true, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "gergegd de erg efg aergae";
            Assert.AreEqual(true, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "              ";
            Assert.AreEqual(true, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "        dfb       ";
            Assert.AreEqual(true, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "sdg gehhrfxg f f  fg r";
            Assert.AreEqual(true, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = " dgswgfe56y6hg";
            Assert.AreEqual(false, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "zgdgfd get55445";
            Assert.AreEqual(false, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "4565 567 6 77";
            Assert.AreEqual(false, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "56655869890653";
            Assert.AreEqual(false, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = ",./,,';'p[;ll;/";
            Assert.AreEqual(false, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "sdsfhdbgfnfhm/khgghmgkhj>[-kl";
            Assert.AreEqual(false, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "dfs/dsds`geggt";
            Assert.AreEqual(false, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "trhfhgfghfn vmu/pjh\\";
            Assert.AreEqual(false, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "gdfxvx cza\\zz||||";
            Assert.AreEqual(false, InputValidator.IsOnlyFromLettersAndSpaces(s));
            s = "   |||  '/'.;.].";
            Assert.AreEqual(false, InputValidator.IsOnlyFromLettersAndSpaces(s));
        }

        [Test]
        public void Test_InputValidator_ContainsSpacesMethod()
        {
            string s;

            s = "";
            Assert.AreEqual(false, InputValidator.ContainsSpaces(s));
            s = "fgsdhsd sdhrsrthrhtr";
            Assert.AreEqual(true, InputValidator.ContainsSpaces(s));
            s = "g ffghfdg f hfgh f";
            Assert.AreEqual(true, InputValidator.ContainsSpaces(s));
            s = " jhjkh j  /[/[  r";
            Assert.AreEqual(true, InputValidator.ContainsSpaces(s));
            s = "f5gh reth456h 5uh hth543";
            Assert.AreEqual(true, InputValidator.ContainsSpaces(s));
            s = "345545 565465";
            Assert.AreEqual(true, InputValidator.ContainsSpaces(s));
            s = "4564 t hjh jhl//;[lkh";
            Assert.AreEqual(true, InputValidator.ContainsSpaces(s));
            s = " 6 56568 /[]'''#$#%$";
            Assert.AreEqual(true, InputValidator.ContainsSpaces(s));
            s = "gfds r5y476iyjl/;'[.lkbj";
            Assert.AreEqual(true, InputValidator.ContainsSpaces(s));
            s = "xfhdhsyybry";
            Assert.AreEqual(false, InputValidator.ContainsSpaces(s));
            s = "fgsddgdgfdhhrsrthrhtr";
            Assert.AreEqual(false, InputValidator.ContainsSpaces(s));
            s = "'/[p'.p[#Q$@%#$#";
            Assert.AreEqual(false, InputValidator.ContainsSpaces(s));
            s = "fhgko;op';mlkjhgfa`w4rgg";
            Assert.AreEqual(false, InputValidator.ContainsSpaces(s));
            s = "3455656768655456";
            Assert.AreEqual(false, InputValidator.ContainsSpaces(s));
            s = "sdgheaohvdoxvd'.\'r]e[ww-334wa||\\\f;//[gekdr";
            Assert.AreEqual(false, InputValidator.ContainsSpaces(s));
        }
    }
}
