
namespace FizzBuzzTest;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void AcceptsAPITokenInput(){

         HttpClient client = new HttpClient();

         string[] expected = new string[2];

         var response = client.GetStringAsync("https://rich-red-cocoon-veil.cyclic.app/random").Result;
         dynamic data = JsonConvert.DeserializeObject(response)!;

         expected[0] = Convert.ToString(data.word);
         expected[1] = Convert.ToString(data.multiple);

         string[] result = response.apiToken();

         Assert.AreEqual(String.Join(' ', expected), String.Join(' ', result));

    }


    [TestMethod]
    public void AcceptsNonSequentialInput(){

        var rand = new Random();
        
        int[] arr = new int[10];
        string[] toStr = new string[arr.Length];
        
 
        for(int i = 0; i < arr.Length; i++){
            arr[i] = (rand.Next(-100,100));
            
        }

        for( int j = 0; j < arr.Length; j++){
            string value = "";

            if(arr[j] % 3 == 0){
                value += "Fizz";
            }
            if(arr[j] % 5 == 0){
                value += "Buzz";
            }
            if(arr[j] % 3 != 0 && arr[j] % 5 != 0){

                value = Convert.ToString(arr[j]);

            }

            toStr[j] = value;
        }

        Assert.AreEqual(String.Join(',', toStr),  String.Join(',', arr.FizzBuzzNonSeq(3,5,"Fizz", "Buzz")));

    }


    [TestMethod]
    public void AcceptsUserDefinedVariables(){

       int num = 10;

       int a = 2;
       int b = 10;
       string fizz = "Test";
       string buzz = "Pass";

       var result = num.FizzBuzzTwist(a,b,fizz,buzz);

       Assert.AreEqual("TestPass", result);

    }
}