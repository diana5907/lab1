using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_1; // Імпорт простору імен, що містить клас Program

namespace UnitTestProject1
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestCalculateHypotenuse()
        {
            // Arrange
            double a = 3; // Оголошення першого катета
            double b = 4; // Оголошення другого катета
            double expectedHypotenuse = 5; // Очікувана гіпотенуза за теоремою Піфагора

            // Act
            double actualHypotenuse = Program.CalculateHypotenuse(a, b); // Виклик методу для обчислення гіпотенузи

            // Assert
            Assert.AreEqual(expectedHypotenuse, actualHypotenuse); // Перевірка, що результат обчислення співпадає з очікуваним значенням
        }

        [TestMethod]
        public void TestCalculatePerimeter()
        {
            // Arrange
            double a = 3; // Оголошення першого катета
            double b = 4; // Оголошення другого катета
            double c = 5; // Оголошення гіпотенузи
            double expectedPerimeter = 12; // Очікуваний периметр прямокутного трикутника

            // Act
            double actualPerimeter = Program.CalculatePerimeter(a, b, c); // Виклик методу для обчислення периметра

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter); // Перевірка, що результат обчислення співпадає з очікуваним значенням
        }
    }
}
