using NUnit.Framework;
using RectangleApp;


namespace AssignmentTest
{
    [TestFixture]
    public class Tests
    {

        Rectangle rect = new Rectangle();

        [Test]
        public void Perimeter_Of_Rectangle()
        {
            int a = 5, b = 10;//arrange
            //rect.SetLength(a);//arrange
            //rect.SetWidth(b);//arrange
            int res = rect.GetPerimeter(a, b); //act
            Assert.AreEqual(res, 30); //assert
        }

        [Test]
        public void Area_Of_Rectangle()
        {
            int a = 5, b = 10;//arrange
            //rect.SetLength(a);//arrange
            //rect.SetWidth(b);//arrange
            int res = rect.GetArea(a, b); //act
            Assert.AreEqual(res, 50); //assert
        }

        [Test]
        public void Get_Length()
        {
            int a = 5;//arrange
            int res = rect.GetLength(a); //act
            Assert.AreEqual(res, 5); //assert
        }

        [Test]
        public void Get_Width()
        {
            int b = 10;//arrange
            int res = rect.GetWidth(b); //act
            Assert.AreEqual(res, 10); //assert
        }

        [Test]
        public void Set_Length()
        {
            int a = 5;//arrange
            rect.SetLength(a);//arrange
            int res = rect.SetLength(a); //act
            Assert.AreEqual(res, 5); //assert
        }

        [Test]
        public void Set_Width()
        {
            int b = 10;//arrange
            rect.SetWidth(b);//arrange
            int res = rect.SetWidth(b); //act
            Assert.AreEqual(res, 10); //assert
        }
    }
}
