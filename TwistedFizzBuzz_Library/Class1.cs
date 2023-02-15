using Newtonsoft.Json;


namespace TwistedFizzBuzz;


public static class TwistedFizzBuzz{

    // Basic implementation of the normal FizzBuzz problem. 

    public static string FizzBuzz(this int num){

        string result = "";
        string a = "Fizz";
        string b = "Buzz";

        if( num % 3 == 0){

            result +=  a;
        }
        if(num % 5 == 0){

            result += b;
        }
        
        if(num % 3 != 0 && num % 5 != 0){

            result = Convert.ToString(num);
        }

        return result;

    }

    // FizzBuzz implementation for second console application. 

    public static string FizzBuzzAlt(this int num){

        string result = "";
        string a = "Fizz";
        string b = "Buzz";
        string c = "Bar";

        if( num % 5 == 0){

            result +=  a;
        }
        if(num % 9 == 0){

            result += b;
        }
        if(num % 27 == 0){

            result += c;
        }
       
        if(num % 27 != 0 && num % 9 != 0 && num % 5 != 0){

            result = Convert.ToString(num);
        }

        return result;
    }

    // Accepts user specified values for divisors and tokens.

    public static string FizzBuzzTwist(this int num, int? a , int? b, string? fizz, string? buzz){

       

        string result = "";

        if( num % a == 0){

            result += fizz;
        }

        if(num % b == 0){

            result += buzz;
        }
        if(num % b != 0 && num % a != 0 ){

            result = Convert.ToString(num);
        }

        return result;

    }

    public static string[] FizzBuzzNonSeq(this int[] nums, int a, int b, string fizz, string buzz){

        string[] result = new string[nums.Length];

        for(int i = 0; i < nums.Length; i++){

            result[i] = nums[i].FizzBuzzTwist(a,b,fizz,buzz);
        }

        return result;
        
    }


    // This function accepts an API response token and parses the information and then returns the output. 

    public static string[] apiToken(this string token){

        dynamic str = JsonConvert.DeserializeObject(token)!;

        string[] result = new string[2];
        
        result[0] = Convert.ToString(str.word);
        result[1] = Convert.ToString(str.multiple);

        return result; 
    }

}
