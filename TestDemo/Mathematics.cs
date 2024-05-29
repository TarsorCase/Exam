namespace TestDemo;

public static class Mathematics
{
 public static double Esfera(double num1) { 
  
 double ans = 4/3 * 3.412 * num1;
 
 return ans;
 }
 public static double Kilometros(double num1) {  

 double ans2 = num1 * 1000;
 
 return ans2;
 }
 public static double Edificio(double num1, double num2) {  
 
  double alphagrados = num2 * (Math.PI/180.0);
  double tanalpha =Math.Tan(alphagrados); 

 double ans3 = num1 * tanalpha;

 return ans3;
 }
}
