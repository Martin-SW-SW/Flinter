using System;

namespace Flinter
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Profile profile1 = new Profile(true, Flinter.Profile.eyeColor.Blue, Flinter.Profile.hairColor.blond, 1);
            Profile profile2 = new Profile(false, Flinter.Profile.eyeColor.Brown, Flinter.Profile.hairColor.white, 4);
            Profile profile3 = new Profile(true, 0, 0, 8);

            Console.WriteLine(profile1.Description);
            Console.WriteLine(profile2.Description);
            Console.WriteLine(profile3.Description);

            // The LAST line of code should be ABOVE this line
        }
    }
}