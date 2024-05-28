namespace TestDemo.Tests;

public class UnitTest1
{
[Fact]  

public void ForceTest() {  

//Arrange  

var num1 = 6; 

var num2 = 6;  

var expectedResult = 36;  

//Act  

var result = Mathematics.Force(num1, num2);  

//Assert  

Assert.Equal(expectedResult, result);  

}  

[Fact]  

public void ForceTestinvalid() {  

//Arrange  

var num1 = 'a'; 

var num2 = 'a';  

var expectedResult = 36;  

//Act  

var result = Mathematics.Force(num1, num2);  

//Assert  

Assert.Equal(expectedResult, result);  

}  
  
[Fact]  

public void WorkTest() { 

//Arrange  
  
var num1 = 5;  

var num2 = 2;  

var expectedResult = 10;  

//Act  

var result = Mathematics.Work(num1, num2);  

//Assert  

Assert.Equal(expectedResult, result);  
} 

[Fact]  

public void WorkTestInvalid() { 

//Arrange  
  
var num1 = 'b';  

var num2 = 'b';  

var expectedResult = 10;  

//Act  

var result = Mathematics.Work(num1, num2);  

//Assert  

Assert.Equal(expectedResult, result);  
}

[Fact]  

public void Kinetic() { 

//Arrange  
  
var num1 = 5;  

var num2 = 5;  

var expectedResult = 62.5;

//Act  

var result = Mathematics.Kinetic(num1, num2);  

//Assert  

Assert.Equal(expectedResult, result,3);  

}  

[Fact]  

public void Kineticinvalid() { 

//Arrange  
  
var num1 = 'a';  

var num2 = 'a';  

var expectedResult = 62.5;

//Act  

var result = Mathematics.Kinetic(num1, num2);  

//Assert  

Assert.Equal(expectedResult, result,3);  

}
}
