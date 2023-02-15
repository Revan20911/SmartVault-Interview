using TwistedFizzBuzz;

class FizzBuzz{

    static void Main(string[] args){

        int count = 0;
        int min = 1;
        int max = 100;
        int a = 3;
        int b = 5;
        string fizz = "Fizz";
        string buzz = "Buzz";
        bool validMin = false;
        bool validMax = false;
        bool hasToken = false;
        string token = "";
        int[] temp = {};
        string res = "";
        

        Console.Write("This is the standard FizzBuzz problem. Please enter the requested items as they appear.\n");

        Console.WriteLine("Would you like to enter numbers non-sequentially? (Y/N)");

        if(Console.ReadLine() == "Y"){
            int n = 0;
            Console.WriteLine("How many numbers would you like to enter?");
            count = Convert.ToInt32(Console.ReadLine());
            
            int[] arr = new int[count];
            do{
                Console.WriteLine("Enter the numbers you would like to use");
                arr[n] = Convert.ToInt32(Console.ReadLine());
                n+=1;

            }while( n < count);

            temp = arr;
        }else{


        Console.WriteLine("Do you want to specify the range? (Y/N) \n Default is 1 - 100");
        var rangeResponse = Console.ReadLine();
        if(rangeResponse == "Y"){

             do{
            
            Console.WriteLine("Enter the first number in the range:");
            var mins = Console.ReadLine();
            if(mins != ""){
                min = Convert.ToInt32(mins);
                validMin = true;

            }else{
                Console.WriteLine("Invalid entry please enter a number");
                validMin = false;
            }
            
        }while(!validMin);

        do{

        Console.WriteLine("Enter the last number in the range:");
        var maxs = Console.ReadLine();
        if(maxs != ""){
            max = Convert.ToInt32(maxs);
            validMax= true;
        }else{

            Console.WriteLine("Invalid entry please enter a number");
            validMax = false;
        }

        }while(!validMax);
        
        }

        }
    
        
       Console.WriteLine("Do you want to specify divisors? (Y/N) \n Default divisors are 3 and 5");
       var divRespons = Console.ReadLine();
       if(divRespons == "Y"){
        do{
            Console.WriteLine("Enter the first divisor");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second divisor");
            b = Convert.ToInt32(Console.ReadLine());

        }while(b == 0);
       }

          Console.WriteLine("Do you want to specify custom words? (Y/N) \n Default words are Fizz and Buzz ");
          if(Console.ReadLine() == "Y"){

            do{

                 Console.WriteLine("You can select up to 2 words");
            Console.WriteLine("Enter your first word");
            var input = Console.ReadLine();
            if( input != ""){

                fizz = input!;
            }

            Console.WriteLine("Enter your second word");
            var input2 = Console.ReadLine();
            if( input != ""){

                buzz = input2!;
            }

            } while(buzz == "Buzz");
           
          }


          Console.WriteLine("Do you want to supply an API token? (Y/N)");
          if(Console.ReadLine() == "Y"){
            hasToken = true;
          }

        

        if(hasToken == true){
            do{

            Console.WriteLine("Enter your API token");
            var value = Console.ReadLine();

            if(value != string.Empty){

                token = value!;
            } else {

                Console.WriteLine("Please enter a valid token");
            }

             
          }while(token == string.Empty);

        }

        
        if(token != ""){

            b = Convert.ToInt32(token!.apiToken()[1]);
            buzz =  token!.apiToken()[0];

        }

        if(count != 0){

            res = String.Join(',' , temp.FizzBuzzNonSeq(a,b,fizz,buzz));

            Console.WriteLine(res);

            return;
        }


        for(int j = min; j < max; j++ ){

            Console.WriteLine($"{j.FizzBuzzTwist(a,b,fizz,buzz)}");
        }
          
    }
}
