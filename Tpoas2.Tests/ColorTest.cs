using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tpoas2;

namespace Tpoas2.Tests
{
    [TestClass]
    public class ColorTest
    {
        // max yarkost
        [TestMethod]
        public void TestMethod1()
        {
            int r = 255;
            int g = 255;
            int b = 255;
            double res = 255;

            Color c = new Color();
            double act = c.yarkost(r, g, b);

            Assert.AreEqual(res, act);
        }
        // max red
        [TestMethod]
        public void TestMethod2()
        {
            int r = 255;
            int g = 0;
            int b = 0;
            double res = 76.5;
            Color c = new Color();
            double act = c.yarkost(r, g, b);
            Assert.AreEqual(res, act);
        }
        // max green
        [TestMethod]
        public void TestMethod3()
        {
            int r = 0;
            int g = 255;
            int b = 0;
            double res = 150.45;
            Color c = new Color();
            double act = c.yarkost(r, g, b);
            Assert.AreEqual(res, act);
        }
        // max blue
        [TestMethod]
        public void TestMethod4()
        {
            int r = 0;
            int g = 0;
            int b = 255;
            double res = 28.05;
            Color c = new Color();
            double act = c.yarkost(r, g, b);
            Assert.AreEqual(res, act);
        }
        // min yarkost
        [TestMethod]
        public void TestMethod5()
        {
            int r = 0;
            int g = 0;
            int b = 0;
            double res = 0;
            Color c = new Color();
            double act = c.yarkost(r, g, b);
            Assert.AreEqual(res, act);
        }
        // green == zero
        [TestMethod]
        public void TestMethod6()
        {
            int r = 255;
            int g = 0;
            int b = 255;
            double res = 104.55;
            Color c = new Color();
            double act = c.yarkost(r, g, b);
            Assert.AreEqual(res, act);
        }
        // blue  == minus
        [TestMethod]
        public void TestMethod7()
        {
            int r = 255;
            int g = 255;
            int b = -70;
            double res = 226.95;
            Color c = new Color();
            double act = c.yarkost(r, g, b);
            Assert.AreEqual(res, act);
        }
        // red == minus && blue > 255
        [TestMethod]
        public void TestMethod8()
        {
            int r = -90;
            int g = 1000;
            int b = 200;
            double res = 172.45;
            Color c = new Color();
            double act = c.yarkost(r, g, b);
            Assert.AreEqual(res, act);
        }
        // yarkost != expected res
        [TestMethod]
        public void TestMethod9()
        {
            int r = 125;
            int g = 125;
            int b = 125;
            double res = 130;
            Color c = new Color();
            double act = c.yarkost(r, g, b);
            Assert.AreNotEqual(res, act);
        }
        // red && green > 255
        [TestMethod]
        public void TestMethod10()
        {
            int r = 300;
            int g = 700;
            int b = 80;
            double res = 235.75;
            Color c = new Color();
            double act = c.yarkost(r, g, b);
            Assert.AreEqual(res, act);
        }
    }
}