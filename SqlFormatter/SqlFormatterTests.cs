using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace SQLParser.Tests
{
    [TestFixture]
    [TestClass]
    public class SqlFormatterTests
    {
        [Test]
        [TestMethod]
        public void SimpleQuery()
        {
            var query =
                @"SELECT * FROM TESTABLEtttV";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    *
FROM TESTABLETTTV";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }


        [Test]
        [TestMethod]
        public void SimpleQueryWithColumns()
        {
            var query = "SELECT name, fio FROM TESTABLEtttV";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    NAME,
    FIO
FROM TESTABLETTTV";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void CASTASNUMERIC()
        {
            var query = "SELECT CAST(F AS NUMERIC(18,2)) as F FROM T2";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
@"SELECT
    CAST(F AS NUMERIC(18,2)) AS F
FROM T2";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void DECLARE()
        {
            var query = "DECLARE @P1 DATETIME2(3), @P2 DATETIME2(3)";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
@"DECLARE @P1 DATETIME2(3), @P2 DATETIME2(3)";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void DECLARE_Select()
        {
            var query = "DECLARE @P1 DATETIME2(3), @P2 DATETIME2(3) SELECT F FROM T";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
@"DECLARE @P1 DATETIME2(3), @P2 DATETIME2(3)
SELECT
    F
FROM T";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void WITH_NOLOCK()
        {
            var query = "SELECT F FROM T2 WITH(NOLOCK)";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
@"SELECT
    F
FROM T2 WITH(NOLOCK)";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void where()
        {
            var query = "SELECT F FROM T2 WHERE F>2";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
@"SELECT
    F
FROM T2
WHERE F > 2";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void CASE()
        {
            var query = "SELECT CASE WHEN F1 = 0.0 THEN -F2 ELSE F2 END FROM T2";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
@"SELECT
    CASE WHEN F1 = 0.0 THEN -F2 ELSE F2 END
FROM T2";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }
        [TestMethod]
        public void AND()
        {
            var query = "SELECT F FROM T2 WHERE F>2 AND F<5";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
@"SELECT
    F
FROM T2
WHERE F > 2 AND F < 5";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void ColumnWithAlias()
        {
            var query = "SELECT name as fio FROM TESTABLEtttV";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    NAME AS FIO
FROM TESTABLETTTV";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }
        

        [TestMethod]
        public void ManyGroupBy()
        {
            var query = @"SELECT F FROM T1 GROUP BY T1.F1,
T1.F2,";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    F
FROM T1
GROUP BY T1.F1, T1.F2";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }
        [TestMethod]
        public void GroupBy()
        {
            var query = "SELECT F FROM T1 GROUP BY F";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    F
FROM T1
GROUP BY F";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void UnionQuery()
        {
            var query = "SELECT name FROM T1 union SELECT fio FROM T2";

            var visiter = new SqlFormatter();
    
            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    NAME
FROM T1
UNION
SELECT
    FIO
FROM T2";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void Having()
        {
            var query = "SELECT NAME FROM T1 GROUP BY T1 HAVING T1>1";

            var visiter = new SqlFormatter();
         
            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    NAME
FROM T1
GROUP BY T1
HAVING T1 > 1";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void JOIN()
        {
            var query = "SELECT name FROM T1 JOIN T2 ON T1.F = T2.F";

            var visiter = new SqlFormatter();
       
            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    NAME
FROM T1
    JOIN T2 ON T1.F = T2.F";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [TestMethod]
        public void inner_JOIN()
        {
            var query = "SELECT name FROM T1 INNER JOIN T2 ON T1.F = T2.F";

            var visiter = new SqlFormatter();
           
            SQLParser.Parser.Parse(query.ToUpper(), visiter, Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    NAME
FROM T1
    INNER JOIN T2 ON T1.F = T2.F";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [Test]
        [TestMethod]
        public void SubQuery()
        {
            var query = "SELECT name FROM (select name from q) as t";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(
                query.ToUpper(),
                visiter,
                Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    NAME
FROM (
---------'T'-------- 0

    SELECT
        NAME
    FROM Q) AS T";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }

        [Test]
        [TestMethod]
        public void ManySubQueryWithUnion()
        {
            var query = "SELECT F FROM (SELECT F FROM T1) as t2 union SELECT F FROM T3";

            var visiter = new SqlFormatter();

            SQLParser.Parser.Parse(
                query.ToUpper(),
                visiter,
                Enums.SQLType.TSql);

            var result = visiter.GetText();

            var expectedResult =
                @"SELECT
    F
FROM (
---------'T2'-------- 0

    SELECT
        F
    FROM T1) AS T2
UNION
SELECT
    F
FROM T3";

            Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result, "Результирующие запросы должны быть равны");
        }
    }
}