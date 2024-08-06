namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestSubtract()
    {
        Assert.Equal(10L, Subtract.Eval(15L, 5L));
    }
    [Fact]
    public void TestMult()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }
    [Fact]
    public void TestDivide()
    {
        Assert.Equal(4L, Divide.Eval(12L, 3L));
    }
    [Fact]
    public void TestModulo()
    {
        Assert.Equal(1L, Modulo.Eval(10L, 3L));
    }

    [Fact]
    public void TestPower()
    {
        Assert.Equal(25L, Power.Eval(5L, 2L));
    }
    [Fact]
    public void TestSquareRoot()
    {
        Assert.Equal(4, SquareRoot.Eval(16));
    }

   

    [Fact]
    public void TestAdd2()
    {
        Assert.Equal(22L, Add.Eval(16L, 6L));
    }
    [Fact]
    public void TestSubtract2()
    {
        Assert.Equal(15L, Subtract.Eval(23L, 8L));
    }
    [Fact]
    public void TestMult2()
    {
        Assert.Equal(20L, Multiply.Eval(4L, 5L));
    }
    [Fact]
    public void TestDivide2()
    {
        Assert.Equal(5L, Divide.Eval(40L, 8L));
    }
    [Fact]
    public void TestAdd3()
    {
        Assert.Equal(12L, Add.Eval(3L, 9L));
    }
    [Fact]
    public void TestSubtract3()
    {
        Assert.Equal(12L, Subtract.Eval(18L, 6L));
    }
    [Fact]
    public void TestMult3()
    {
        Assert.Equal(28L, Multiply.Eval(7L, 4L));
    }
    [Fact]
    public void TestDivide3()
    {
        Assert.Equal(5L, Divide.Eval(35L, 7L));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestSubtractOperation()
    {
        Assert.Equal(4, Evaluator.Eval("-", 16, 12));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void TestDivideOperation()
    {
        Assert.Equal(4, Evaluator.Eval("/", 8, 2));
    }
    [Fact]
    public void TestModuloOperation()
    {
        Assert.Equal(2, Evaluator.Eval("%", 18, 4));
    }
    [Fact]
    public void TestPowerOperation()
    {
        Assert.Equal(27, Evaluator.Eval("^", 3, 3));
    }
    [Fact]
    public void TestSquareRootOperation()
    {
        Assert.Equal(3, Evaluator.Eval("sqrt", 9));
    }

    [Fact]
    public void TestSquareRootOfZero()
    {
        Assert.Equal(0f, SquareRoot.Eval(0f));
    }

    [Fact]
    public void TestSquareRootOfOne()
    {
        Assert.Equal(1f, SquareRoot.Eval(1f));
    }

    [Fact]
    public void TestSquareRootOfNegativeNumber()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => SquareRoot.Eval(-1f));
    }


    [Fact]
    public void TestSquareRootOfFraction()
    {
        Assert.Equal(0.5f, SquareRoot.Eval(0.25f));
    }

    // [Fact]
    // public void TestSquareRootOfNegativeNumber()
    //{
    //   Assert.Throws<ArgumentException>(() => SquareRoot.Eval(-1f));
    // }
    //[Fact]
    //public void TestInvalidOperation()
    //{
    //  Assert.Throws<Exception>(() => Evaluator.Eval("%", 9, 9));
    // }

    [Fact]
    public void TestContinueOperations()
    {
        // This test simulates continuous operations
        float result1 = Evaluator.Eval("+", 5, 10);
        Assert.Equal(15, result1);
        float result2 = Evaluator.Eval("-", result1, 5);
        Assert.Equal(10, result2);
        float result3 = Evaluator.Eval("*", result2, 2);
        Assert.Equal(20, result3);
        float result4 = Evaluator.Eval("/", result3, 4);
        Assert.Equal(5, result4);
        float result5 = Evaluator.Eval("%", result4, 2);
        Assert.Equal(1, result5);
        float result6 = Evaluator.Eval("^", result5, 2);
        Assert.Equal(1, result6);
        float result7 = Evaluator.Eval("sqrt", result6);
        Assert.Equal(1, result7);
    }
    //[Fact]
    // public void TestDivideByZero()
    //{
    //  Assert.Throws<DivideByZeroException>(() => Divide.Eval(10L, 0L));
    //}



    [Fact]
    public void TestPercentage_ValidValues()
    {
        // Testing with normal values
        Assert.Equal(20, Percentage.Eval(200, 10));  // 10% of 200 is 20
    }

    [Fact]
    public void TestPercentage_ZeroPercent()
    {
        // Testing when percentage is zero
        Assert.Equal(0, Percentage.Eval(200, 0));  // 0% of 200 is 0
    }

    [Fact]
    public void TestPercentage_ZeroValue()
    {
        // Testing when value is zero
        Assert.Equal(0, Percentage.Eval(0, 10));  // 10% of 0 is 0
    }

    [Fact]
    public void TestPercentage_OverHundredPercent()
    {
        // Testing when percentage is more than 100
        Assert.Equal(250, Percentage.Eval(200, 125));  // 125% of 200 is 250
    }

    [Fact]
    public void TestPercentage_NegativeValue()
    {
        // Testing with negative values
        Assert.Equal(-20, Percentage.Eval(-200, 10));  // 10% of -200 is -20
    }

    [Fact]
    public void TestPercentage_NegativePercent()
    {
        // Testing with negative percentages
        Assert.Equal(-20, Percentage.Eval(200, -10));  // -10% of 200 is -20
    }


    [Fact]
    public void TestStoreValueInMemory()
    {
        // Arrange
        float valueToStore = 42;

        // Act
        Evaluator.Eval("store", valueToStore);
        float storedValue = Evaluator.Eval("recall");

        // Assert
        Assert.Equal(valueToStore, storedValue);
    }

    [Fact]
    public void TestRecallValueFromMemory()
    {
        // Arrange
        float valueToStore = 99;
        Evaluator.Eval("store", valueToStore);

        // Act
        float recalledValue = Evaluator.Eval("recall");

        // Assert
        Assert.Equal(valueToStore, recalledValue);
    }

    [Fact]
    public void TestClearMemory()
    {
        // Arrange
        float valueToStore = 75;
        Evaluator.Eval("store", valueToStore);

        // Act
        Evaluator.Eval("clear");
        float recalledValueAfterClear = Evaluator.Eval("recall");

        // Assert
        Assert.Equal(0f, recalledValueAfterClear);  // Assuming default memory value is 0
    }

    [Fact]
    public void TestStoreAndClearMemory()
    {
        // Arrange
        float valueToStore = 85;
        Evaluator.Eval("store", valueToStore);

        // Act
        Evaluator.Eval("clear");
        float recalledValueAfterClear = Evaluator.Eval("recall");

        // Assert
        Assert.Equal(0f, recalledValueAfterClear);  // Memory should be cleared
    }

    [Fact]
    public void TestStoreAndPerformOperation()
    {
        // Arrange
        float valueToStore = 10;
        Evaluator.Eval("store", valueToStore);

        // Act
        float result = Evaluator.Eval("+", Evaluator.Eval("recall"), 5);

        // Assert
        Assert.Equal(15, result);  // 10 (stored) + 5 = 15
    }

    [Fact]
    public void TestRecallWithNoStoredValue()
    {
        // Act
        float recalledValue = Evaluator.Eval("recall");

        // Assert
        Assert.Equal(0f, recalledValue);  // Assuming default memory value is 0
    }

    public class FactorialTests
    {
        [Fact]
        public void TestFactorial_Zero()
        {
            // Test factorial of 0, which should be 1
            Assert.Equal(1f, Factorial.Eval(0));
        }

        [Fact]
        public void TestFactorial_One()
        {
            // Test factorial of 1, which should be 1
            Assert.Equal(1f, Factorial.Eval(1));
        }

        [Fact]
        public void TestFactorial_Two()
        {
            // Test factorial of 2, which should be 2
            Assert.Equal(2f, Factorial.Eval(2));
        }

        [Fact]
        public void TestFactorial_Five()
        {
            // Test factorial of 5, which should be 120
            Assert.Equal(120f, Factorial.Eval(5));
        }

        [Fact]
        public void TestFactorial_Ten()
        {
            // Test factorial of 10, which should be 3628800
            Assert.Equal(3628800f, Factorial.Eval(10));
        }

        [Fact]
        public void TestFactorial_NegativeNumber()
        {
            // Test factorial of a negative number, should throw ArgumentException
            Assert.Throws<ArgumentException>(() => Factorial.Eval(-1));
        }

       
    }


}