using System;
using System.Text;

public class RomanConversion {

    public static String GetRomanNumber(int x) 
    {
        StringBuilder sb = new StringBuilder ();
        if (x >= 100) {
            sb = ConvertHundreds(x, sb);
        } else if (x >= 10) {
            sb = ConvertTens(x, sb);
        } else {
            sb = ConvertOnes(x, sb);
        }
        return sb.ToString();
    }

    private static StringBuilder ConvertHundreds (int x, StringBuilder sb) 
    {
        if(x>=100){
            sb.Append("C");
        } else if(x>=200){
            sb.Append("CC");
        } else if(x>=300){
            sb.Append("CCC");
        } else if(x>= 400){
            sb.Append("CD");
        } else if(x>=500){
            sb.Append("D");
        } else if(x>= 600){
            sb.Append("DC");
        } else if(x>= 700){
            sb.Append("DCC");
        } else if(x>= 800){
            sb.Append("DCCC");
        } else if(x>= 900){
            sb.Append("CM");
        }

        return sb;
    }

    private static StringBuilder ConvertTens(int x, StringBuilder sb)
    {
        if(x>=10){
            sb.Append("X");
        } else if(x>=20){
            sb.Append("XX");
        } else if(x>=30){
            sb.Append("XXX");
        } else if(x>=40){
            sb.Append("XL");
        } else if(x>=50){
            sb.Append("L");
        } else if(x>=60){
            sb.Append("LX");
        } else if(x>=70){
            sb.Append("LXX");
        } else if(x>= 80){
            sb.Append("LXXX");
        } else if(x>=90){
            sb.Append("XC");
        }
        return sb;
    }

    private static StringBuilder ConvertOnes(int x, StringBuilder sb)
    {
        if(x>=1){
            sb.Append("I");
        } else if(x>= 2){
            sb.Append("II");
        } else if(x>=3){
            sb.Append("III");
        } else if(x>=4){
            sb.Append("IV");
        } else if (x>=5){
            sb.Append("V");
        } else if(x>=6){
            sb.Append("VI");
        } else if(x>=7){
            sb.Append("VII");
        } else if(x>=8){
            sb.Append("VIII");
        } else if(x>=9) {
            sb.Append("IX");
        }
        return sb;
    }

}