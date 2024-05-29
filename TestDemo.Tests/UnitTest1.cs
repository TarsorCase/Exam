namespace TestDemo.Tests;

public class UnitTest1
{
[Fact]  

public void EsferaTest() {  

//Arrange  

var num1 = 6;   

var expectedResult = 27.2958;  

//Act  

var result = Mathematics.Esfera(num1);  

//Assert  

Assert.Equal(expectedResult, result, 3);  

}  

[Fact]  

public void KilometrosTest() { 

//Arrange  
  
var num1 = 5;    

var expectedResult = 5000;  

//Act  

var result = Mathematics.Work(num1);  

//Assert  

Assert.Equal(expectedResult, result);  
} 

[Fact]  

public void EdificioTest() { 

//Arrange  
  
var num1 = 50;  

var num2 = 30;  

var expectedResult = 28.85;

//Act  

var result = Mathematics.Test(num1, num2);  

//Assert  

Assert.Equal(expectedResult, result,3);  

}  

}
