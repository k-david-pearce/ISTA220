using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4C_Farm_Part_2
{
    class EX4CMain
    {
        static void Main(string[] args)
        {
            try
            {
                Pig Porky = new Pig("Porky");
                Console.WriteLine("I am a pig and I say {0}", Porky.speak());
                Console.WriteLine("I am a pig and I eat {0}", Porky.eat());
                Console.WriteLine($"I am a pig and I star in this movie: {Porky.movie()}");
                Console.WriteLine($"I am a pig and I produce {Porky.product()}");

                Pig Wilbur = new Pig("Wilbur");
                Console.WriteLine("I am a pig and I say {0}", Wilbur.speak());
                Console.WriteLine("I am a pig and I eat {0}", Wilbur.eat());
                Console.WriteLine($"I am a pig and I star in this movie: {Wilbur.movie()}");
                Console.WriteLine($"I am a pig and I produce {Wilbur.product()}");

                Pig MissPiggy = new Pig();
                Console.WriteLine("I am a pig and I say {0}", MissPiggy.speak());
                Console.WriteLine("I am a pig and I eat {0}", MissPiggy.eat());
                Console.WriteLine($"I am a pig and I star in this movie: {MissPiggy.movie()}");
                Console.WriteLine($"I am a pig and I produce {MissPiggy.product()}");

                Pig Napolean = new Pig();
                Console.WriteLine("I am a pig and I say {0}", Napolean.speak());
                Console.WriteLine("I am a pig and I eat {0}", Napolean.eat());
                Console.WriteLine($"I am a pig and I star in this movie: {Napolean.movie()}");
                Console.WriteLine($"I am a pig" +
                    $" and I produce {Napolean.product()}"); 
                
                Horse MrEd = new Horse("Mr. Ed");
                Console.WriteLine("I am a horse and I say {0}", MrEd.speak());
                Console.WriteLine("I am a horse and I eat {0}", MrEd.eat());

                Horse blackBeauty = new Horse("Black Beauty");
                Console.WriteLine($"I am a horse and I star in this movie: {blackBeauty.movie()}");
                Console.WriteLine($"I am a horse and I produce {blackBeauty.product()}");

                Cow Steak = new Cow("Steak");
                Console.WriteLine("I am a cow and I say {0}", Steak.speak());
                Console.WriteLine("I am a cow and I eat {0}", Steak.eat());
                Cow Daisy = new Cow("Daisy");
                Console.WriteLine($"I am a cow and I star in this movie: {Daisy.movie()}");
                Console.WriteLine($"I am a cow and I produce {Daisy.product()}");

                Chicken Nugget = new Chicken("Nugget");
                Console.WriteLine("I am a chicken and I say {0}", Nugget.speak());
                Console.WriteLine("I am a chicken and I eat {0}", Nugget.eat());
                Chicken Rooster = new Chicken("Rooster");
                Console.WriteLine($"I am a chicken and I star in this movie: {Rooster.movie()}");
                Console.WriteLine($"I am a chicken and I produce {Rooster.product()}");

            }
            catch (NotImplementedException NIex)
            {
                Console.WriteLine(NIex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Error handling complete");
            }
        }
    }
}
