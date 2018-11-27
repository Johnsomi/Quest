using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Quest_of_The_Noble_Son
{
    class Program
    {
        private static void printInvo(List<string> Inventory)
        {
            int i = 0;
            while (i < Inventory.Count)
            {
                Console.Write(Inventory[i] + ", ");
                i++;

            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {

            List<string> Inventory = new List<string>();
            Inventory.Add("String");


            double instaKill = 10000000000000000000.0;
            double rustyBlade = 4.0;
            double leatherArmor = 4.0;
            double playerMaxHP = 15.0;
            double playerHP = 15.0;
            double playerATK = 3.0;
            double playerDEF = 3.0;
            double playerEquipATK = playerATK + rustyBlade;
            double playerEquipDEF = playerDEF + leatherArmor;
            double Crit = playerEquipATK * 1.5;

            int Gold = 0;
            


            Console.Write(@"Welcome to 'Title Here'
First and only question.
Are you a boy, a girl, or other
(A). Male?
(B). Female?
(C). Other?

");
            while (true)
            {
                string genderChoice = Console.ReadLine();
                //*
                if (genderChoice == "A" || genderChoice == "a")
                {
                    Console.Write(@"Alright, on to the story.

");
                    break;
                }
                //*
                if (genderChoice == "B" || genderChoice == "b")
                {
                    Console.Write(@"Alright, on to the story.
Anyway, your playing as a guy.
I only did this to make people think they could choose.

");
                    break;
                }
                //*
                if (genderChoice == "C" || genderChoice == "b")
                {
                    Console.Write(@"Wrong, try again.

");
                    continue;
                }
                //*
                else
                {
                    continue;
                }
            }


            Console.ReadKey();
            //Line 94, below 95
            Console.Write(@"3 years ago, King Allius “passed away” leaving the throne to his son, Galus. 
Though unlike most stories nowadays, Galus was actually a much better king than his father. 
King Allius was a very greedy man. 
Raising massive taxes for the common folk while having no change for the nobles. 
Doing this lead the country into chaos. 
Though before a revolution could take place, Prince Galus killed his father while he slept.

");
            Console.ReadKey();

            Console.Write(@"With the old king gone, the people rejoiced, but many didn’t for long knowing that his son would take the throne. 
The country could fall even deeper into chaos knowing that the nobles would take the reins and lead the country to ruin.
Though to everyone's surprise and the citizens joy. 
Galus removed almost all of the nobles from his father’s court and went on to make new nobles judged by his standards.

");
            Console.ReadKey();

            Console.Write(@"Though he wasn’t electing nobles on their social standing or the amount of money they possessed like many thought he would, but by their spit and vigor. 
In other words if he liked you for you, he’d might make you a noble. 
Even from a young age Galus had always seen the citizens as more than just people to walk on and to stand over. 
AND YOU, THE PLAYER, YOU...

");
            Console.ReadKey();

            Console.Write(@"Are not him! 
Your the son/daughter of one of the nobles he kicked out. 
Raised with money just to lose it all forcing your family into debt because they wanted to keep there GLORIOUS lifestyle. 
So your quest AAANNNDDD it’s gone, the, the script, it’s all gone… Welp… this is awkward… 
time to wing it!

");
            Console.ReadKey();

            Console.Write(@"So, here's the gist of it. 
Your on a quest to payoff your sibling’s debt, not your parents though well you could, it don’t matter much. 
You already payed off your’s, selling everything you could and I mean EVERYTHING. 
It wasn’t pretty. 
Anyway, you're going to there to get the money that’s supposedly at the end of it. 
You had saved up to buy new gear to complete this quest, but somewhere on the way there you were robbed so you don't have much left.
You have your tattered hardened leather armor as well as some plated gloves and steel toe boots. 
Why they didn't take your shoes, we'll never know.
There’s also an old dagger your grandfather had used in his youth.
Also the debt is 500,000 gold EACH and you have 2 siblings so, 1,000,000 gold for the two of them.

");
            Console.ReadKey();

            Console.WriteLine(@"Well that should be it
Would you like to play?
(A). Yes
(B). No
");
            int StartGameJoke = 0;

            while (StartGameJoke < 4)
            {

                string StartGame = Console.ReadLine();

                if (StartGame == "A" || StartGame == "a")
                {
                    Console.WriteLine(@"Great! Let us begin!
");
                    break;
                }

                if ((StartGameJoke < 3) && (StartGame == "B" || StartGame == "b"))
                {
                    Console.WriteLine("HA! Try again.");
                    StartGameJoke++;
                    continue;

                }

                if ((StartGameJoke >= 3) && (StartGame == "B" || StartGame == "b"))
                {
                    Console.WriteLine(@"Well saddle up Seabiscuit. You ain't the one in control.
");
                    Console.ReadKey();
                    break;
                }



            }

            Console.WriteLine(@"So you decided to play? Excellent!
So where did I leave off...
");
            Console.ReadKey();

            Console.Write(@"You just got mugged, ain't this some shit.
Alright, so you don't have any money, your in the middle of a forest path, and the sun is going down.
What do you do?
(A). Make a fire?
(B). Go find food?
(C). Continue to walk down the path?
(D). Check status / inventory?

");

            while (true)
            {

                string woodsMove1 = Console.ReadLine();
                //-
                if (woodsMove1 == "A" || woodsMove1 == "a")
                {
                    Console.Write(@"You decided to make a fire.
You look around and pick up a few branches and dead leaves and put them in a pile.
How do you want to light it?
(A). Hand drill?
(B). Hit rocks together?
(C). Fire plow?
(D). Pray?
(E). Check status / inventory?

");

                    while (true)
                    {

                        string woodsFireMove1 = Console.ReadLine();
                        //*
                        if (woodsFireMove1 == "A" || woodsFireMove1 == "a")
                        {
                            Console.Write(@"You try the hand drill method to start the fire.
The stick breaks.

");
                            continue;
                        }
                        //-
                        if (woodsFireMove1 == "B" || woodsFireMove1 == "b")
                        {
                            Console.Write(@"You pick up two rocks from the ground and smack them together.
The stones make a spark almost instantly and the fire starts.
You realize one of the rocks is a piece of flint.
Would you like to keep it?
(A). Yes?
(B). No?

");

                            while (true)
                            {
                                string FlintChoice = Console.ReadLine();
                                //*
                                if (FlintChoice == "A" || FlintChoice == "a")
                                {
                                    Inventory.Add("Flint");
                                    //inventory = inventory + flint;
                                    Console.Write(@"You decided to keep the flint.
Flint was added to your inventory.

");
                                    break;
                                }
                                //*
                                if (FlintChoice == "B" || FlintChoice == "b")
                                {
                                    Console.Write(@"Are you sure?
(A). Yes?
(B). No?

");
                                    while (true)
                                    {
                                        string flintChoice2 = Console.ReadLine();
                                        //*
                                        if (flintChoice2 == "A" || flintChoice2 == "a")
                                        {
                                            Inventory.Add("Flint");
                                            //inventory = inventory + flint;
                                            Console.Write(@"You decided to keep the flint.
Flint was added to your inventory.

");
                                            break;

                                        }
                                        //*
                                        if (flintChoice2 == "B" || flintChoice2 == "b")
                                        {
                                            Inventory.Add("Flint");
                                            //inventory = inventory + flint;
                                            Console.Write(@"You decided to keep the flint because your not a dumbass.
Flint was added to your inventory.

");
                                            break;
                                        }
                                        //*
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                //*
                                else
                                {
                                    continue;
                                }
                            }
                            //-
                            Console.Write(@"Since you have a fire going now,
What do you wish to do?
(A). Go to sleep?
(B). Look for food?
(C). Check status / inventory?

");
                            while (true)
                            {
                                string woodsFireflint = Console.ReadLine();
                                //-304
                                if (woodsFireflint == "A" || woodsFireflint == "a")
                                {
                                    Console.Write(@"Where do you sleep?
(A). In tree?
(B). On ground?

");
                                    while (true)
                                    {
                                        string sleepByFire = Console.ReadLine();
                                        //-315
                                        if (sleepByFire == "A" || sleepByFire == "a")
                                        {
                                            //T2 = Virginia Creeper
                                            Console.Write(@"You decide to sleep in a tree.
There are 3 different trees to choose from.
The first is an evergreen, the branches are low and it's prickly, but will hide you.
The second is a tall oak tree, it's covered in leafy vines so it'll be easy to climb.
The last one is a old twisted tree, the roots are so exposed you could hide under the tree.
Which one?
(A). The first?
(B). The second?
(C). The third?

");
                                            while (true)
                                            {
                                                string treeChoice = Console.ReadLine();
                                                //-326
                                                if (treeChoice == "A" || treeChoice == "a")
                                                {
                                                    Console.Write(@"You choose to sleep in the evergreen.
It's very hard to get comfortable, but you won't be seen.
Hopefully.
");
                                                    Console.ReadKey();
                                                    Console.Write(@"Morning arrives.
You didn't sleep that well, but it was enough.
You try to get up but you stuck.
It's the sap, it's stuck to your armor.
What do you do?
(A). Slide out of your armor?
(B). Cut yourself free?
(C). Rip yourself off?

");
                                                    while (true)
                                                    {
                                                        string stuckGreenSap = Console.ReadLine();
                                                        //-347
                                                        if (stuckGreenSap == "A" || stuckGreenSap == "a")
                                                        {
                                                            playerEquipDEF = playerEquipDEF - leatherArmor;
                                                            Console.Write(@"You slide out of your armor and excape the tree grasp.
Problem, your armor still stuck.
Do you want it?
(A). Yes?
(B). No?

");
                                                            while (true)
                                                            {
                                                                string getBackArmorTree = Console.ReadLine();
                                                                //-367
                                                                if (getBackArmorTree == "A" || getBackArmorTree == "a")
                                                                {
                                                                    Console.Write(@"You decided to get your armor back.
How will you do that?
(A). Melt the sap off?
(B). Cut off armor?
(C). Rip it off?

");
                                                                    while (true)
                                                                    {
                                                                        string getBackArmorTreeM2 = Console.ReadLine();
                                                                        //-382
                                                                        if (getBackArmorTreeM2 == "A" || getBackArmorTreeM2 == "a")
                                                                        {
                                                                            Console.Write(@"The fire's out and you used up all the branches in the area.
And don't say, ''Your in a forest, how are you out of branches?''
It's a bitch to burn fresh wood.
So what do you do?
(A). Cut off armor?
(B). Rip off armor?
(C). look for more branches?

");
                                                                            while (true)
                                                                            {
                                                                                string getBackArmorTreeM3 = Console.ReadLine();
                                                                                //-395
                                                                                if (getBackArmorTreeM3 == "A" || getBackArmorTreeM3 == "a")
                                                                                {
                                                                                    Console.Write(@"You decided to cut off your armor.
What do you want to cut?
(A). The armor?
(B). The sap?
(C). The bark?

");
                                                                                    while (true)
                                                                                    {
                                                                                        string cutArmorFreeTree = Console.ReadLine();
                                                                                        //-410
                                                                                        if (cutArmorFreeTree == "A" || cutArmorFreeTree == "a")
                                                                                        {
                                                                                            leatherArmor = leatherArmor - 1.5;
                                                                                            playerEquipDEF = playerEquipDEF + leatherArmor;
                                                                                            Console.Write(@"You cut your armor off.
You were able to get your armor back, but it's damaged.
Well, now that you have everything what will you do?
(A). Walk the forest path back to civilisation?
(B). BITCH! I WANT BREAKFAST! Look for food?
");
                                                                                            while (true)
                                                                                            {
                                                                                                string gotArmorBackDamaged = Console.ReadLine();
                                                                                                //*
                                                                                                if (gotArmorBackDamaged == "A" || gotArmorBackDamaged == "a")
                                                                                                {
                                                                                                    Console.Write(@"You get back on the forest path and continue on your journey.
A few hours pass and you've made alot of progress.
Your about 3/4ths of the way there.
You should be able to see the village at the top of a hill.
Oh shit, there's one to your left!
Climb it?
(A). Yes?
(B). No? 

");
                                                                                                    while (true)
                                                                                                    {
                                                                                                        string climbHillChoice = Console.ReadLine();
                                                                                                        //*
                                                                                                        if (climbHillChoice == "A" || climbHillChoice == "a")
                                                                                                        {
                                                                                                            Console.Write(@"You climb up the hill to see the village.
At the top of the hill you can see for miles around.
there is also a large tree full of very large, yet very strange fruit.
And in the corner of your eye you see...
What, I'm in the middle of something here.
Ahhhh, give me a minute.
(yeah, yeah, ok, but what abo-, oh, Oh, OOHHOOHH, well... this will be fun)
Little change of plans.
Worst part of it is you don't know what changed.
Anyway, you can see the town.
What do you want to do?
(A). Eat the fruit?
(B). Head to town?

");
                                                                                                            while (true)
                                                                                                            {
                                                                                                                string theFruitTree = Console.ReadLine();
                                                                                                                //*LV2
                                                                                                                if (theFruitTree == "A" || theFruitTree == "a")
                                                                                                                {
                                                                                                                    Console.Write(@"You grab one of the strange fruit from the tree.
The second your hand touches the fruit, you start to feel an uncontrollable hunger.
You bite down on the strange fruit and the hunger stops.
Nothing happened. NOTHING! THE FUCK! WHERE'S THE- 
A flash of light blinds you.
Oh shit there it is.
Good luck.
Hey write this down to get to next level: NWtreeDgArmLV2");
                                                                                                                    Console.ReadKey();
                                                                                                                    Environment.Exit(0);
                                                                                                                }
                                                                                                                //*
                                                                                                                if (theFruitTree == "B" || theFruitTree == "b")
                                                                                                                {
                                                                                                                    Console.Write(@"You decided to leave the fruit and head to town.
You turn around to head to go to the village, but one of the fruit is on the ground in front you.
Pick it up?
(A). Yes?
(B). No?

");
                                                                                                                    while (true)
                                                                                                                    {
                                                                                                                        string pickUpApple = Console.ReadLine();
                                                                                                                        //*LV2
                                                                                                                        if (pickUpApple == "A" || pickUpApple == "a")
                                                                                                                        {
                                                                                                                            Console.Write(@"You pick up the fruit.
The second your hand touches the fruit, you start to feel an uncontrollable hunger.
You bite down on the strange fruit and the hunger stops.
Nothing happened. NOTHING! THE FUCK! WHERE'S THE- 
A flash of light blinds you.
Oh shit there it is.
Good luck.
Hey write this down to get to next level: NWtreeDgArmLV2");
                                                                                                                            Console.ReadKey();
                                                                                                                            Environment.Exit(0);
                                                                                                                        }
                                                                                                                        //*
                                                                                                                        if (pickUpApple == "B" || pickUpApple == "b")
                                                                                                                        {
                                                                                                                            Console.Write(@"You walk past it heading back to the forest path.
But the trees start to change, moving and pushing into your face screaming
EAT! EAT! EAT!
Do you eat it?
(A). Yes?
(B). No?

");
                                                                                                                            while (true)
                                                                                                                            {
                                                                                                                                string treeForcesFruit = Console.ReadLine();
                                                                                                                                //*LV2
                                                                                                                                if (treeForcesFruit == "A" || treeForcesFruit == "a")
                                                                                                                                {
                                                                                                                                    Console.Write(@"You chose to eat the fruit.
The second your hand touches the fruit, you start to feel an uncontrollable hunger.
You bite down on the strange fruit and the hunger stops.
A flash of light blinds you.
GOD DAMN!
You took a lot of convicing.
Well, good luck.
Hey write this down to get to next level: NWtreeDgArmLV2");
                                                                                                                                    Console.ReadKey();
                                                                                                                                    Environment.Exit(0);
                                                                                                                                }
                                                                                                                                //*LV2
                                                                                                                                if (treeForcesFruit == "B" || treeForcesFruit == "b")
                                                                                                                                {
                                                                                                                                    Console.Write(@"Everything freezes.
Nothing is moving.
Nothing can move, not even you.
You hear footsteps coming up from behind.
You can't turn around to see who's behind you, but it won't be needed.
They get right in your face and say-
What am I doing.
I'm not gonna narrate myself.
Look just eat the fruit damnit.
(A). Yes
(B). No

");
                                                                                                                                    Console.ReadKey();
                                                                                                                                    playerHP = 1.0;
                                                                                                                                    Console.Write(@"You know what, I don't care anymore.
You get pimp slapped and the fruit is forced down your throat.
Everything goes white.
Damn!
That took much more than necessary.
Hey write this down to get to next level: NWtreeDgArmBchLV2");
                                                                                                                                    Console.ReadKey();
                                                                                                                                    Environment.Exit(0);
                                                                                                                                }
                                                                                                                                //*
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    continue;
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                        //*
                                                                                                                        else
                                                                                                                        {
                                                                                                                            continue;
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                                //*
                                                                                                                else
                                                                                                                {
                                                                                                                    continue;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                        //*
                                                                                                        if (climbHillChoice == "B" || climbHillChoice == "b")
                                                                                                        {
                                                                                                            Console.Write(@"You walk past the hill and continue towards the village.
You walk torwards the village, but something is definitely off.
You know this because you a hill, the same hill.
Do you climb it?
(A). Yes?
(B). No?

");
                                                                                                            while (true)
                                                                                                            {
                                                                                                                string climbHillChoice2 = Console.ReadLine();
                                                                                                                //*
                                                                                                                if (climbHillChoice2 == "A" || climbHillChoice2 == "a")
                                                                                                                {
                                                                                                                    Console.Write(@"You climb up the hill to see the village.
At the top of the hill you can see for miles around.
there is also a large tree full of very large, yet very strange fruit.
What do you want to do?
(A). Eat the fruit?
(B). Head to town?

");
                                                                                                                    while (true)
                                                                                                                    {
                                                                                                                        string theFruitTree = Console.ReadLine();
                                                                                                                        //*LV2
                                                                                                                        if (theFruitTree == "A" || theFruitTree == "a")
                                                                                                                        {
                                                                                                                            Console.Write(@"You grab one of the strange fruit from the tree.
The second your hand touches the fruit, you start to feel an uncontrollable hunger.
You bite down on the strange fruit and the hunger stops.
Nothing happened. NOTHING! THE FUCK! WHERE'S THE- 
A flash of light blinds you.
Oh shit there it is.
Good luck.
Hey write this down to get to next level: NWtreeDgArmLV2");
                                                                                                                            Console.ReadKey();
                                                                                                                            Environment.Exit(0);
                                                                                                                        }
                                                                                                                        //*
                                                                                                                        if (theFruitTree == "B" || theFruitTree == "b")
                                                                                                                        {
                                                                                                                            Console.Write(@"You decided to leave the fruit and head to town.
You turn around to head to go to the village, but one of the fruit is on the ground in front you.
Pick it up?
(A). Yes?
(B). No?

");
                                                                                                                            while (true)
                                                                                                                            {
                                                                                                                                string pickUpApple = Console.ReadLine();
                                                                                                                                //*LV2
                                                                                                                                if (pickUpApple == "A" || pickUpApple == "a")
                                                                                                                                {
                                                                                                                                    Console.Write(@"You pick up the fruit.
The second your hand touches the fruit, you start to feel an uncontrollable hunger.
You bite down on the strange fruit and the hunger stops.
Nothing happened. NOTHING! THE FUCK! WHERE'S THE- 
A flash of light blinds you.
Oh shit there it is.
Good luck.
Hey write this down to get to next level: NWtreeDgArmLV2");
                                                                                                                                    Console.ReadKey();
                                                                                                                                    Environment.Exit(0);
                                                                                                                                }
                                                                                                                                //*
                                                                                                                                if (pickUpApple == "B" || pickUpApple == "b")
                                                                                                                                {
                                                                                                                                    Console.Write(@"You walk past it heading back to the forest path.
But the trees start to change, moving and pushing into your face screaming
EAT! EAT! EAT!
Do you eat it?
(A). Yes?
(B). No?

");
                                                                                                                                    while (true)
                                                                                                                                    {
                                                                                                                                        string treeForcesFruit = Console.ReadLine();
                                                                                                                                        //*LV2
                                                                                                                                        if (treeForcesFruit == "A" || treeForcesFruit == "a")
                                                                                                                                        {
                                                                                                                                            Console.Write(@"You chose to eat the fruit.
The second your hand touches the fruit, you start to feel an uncontrollable hunger.
You bite down on the strange fruit and the hunger stops.
A flash of light blinds you.
GOD DAMN!
You took a lot of convicing.
Well, good luck.
Hey write this down to get to next level: NWtreeDgArmLV2");
                                                                                                                                            Console.ReadKey();
                                                                                                                                            Environment.Exit(0);
                                                                                                                                        }
                                                                                                                                        //*LV2
                                                                                                                                        if (treeForcesFruit == "B" || treeForcesFruit == "b")
                                                                                                                                        {
                                                                                                                                            Console.Write(@"Everything freezes.
Nothing is moving.
Nothing can move, not even you.
You hear footsteps coming up from behind.
You can't turn around to see who's behind you, but it won't be needed.
They get right in your face and say-
What am I doing.
I'm not gonna narrate myself.
Look just eat the fruit damnit.
(A). Yes
(B). No

");
                                                                                                                                            Console.ReadKey();
                                                                                                                                            playerHP = 1.0;
                                                                                                                                            Console.Write(@"You know what, I don't care anymore.
You get pimp slapped and the fruit is forced down your throat.
Everything goes white.
Damn!
That took much more than necessary.
Hey write this down to get to next level: NWtreeDgArmBchLV2");
                                                                                                                                            Console.ReadKey();
                                                                                                                                            Environment.Exit(0);
                                                                                                                                        }
                                                                                                                                        //*
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            continue;
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                //*
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    continue;
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                        //*
                                                                                                                        else
                                                                                                                        {
                                                                                                                            continue;
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                                //*x
                                                                                                                if (climbHillChoice2 == "B" || climbHillChoice2 == "b")
                                                                                                                {
                                                                                                                    Console.Write(@"You climb up the hill to see the village.
At the top of the hill you can see for miles around.
there is also a large tree full of very large, yet very strange fruit.
What do you want to do?
(A). Eat the fruit?
(B). Head to town?

");
                                                                                                                    continue;
                                                                                                                }
                                                                                                                //*
                                                                                                                else
                                                                                                                {
                                                                                                                    continue;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                        //*
                                                                                                        else
                                                                                                        {
                                                                                                            continue;
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                                //-420
                                                                                                if (gotArmorBackDamaged == "B" || gotArmorBackDamaged == "b")
                                                                                                {
                                                                                                    Console.Write(@"You go look for food.
After searching for about a hour, you see a large buck.
It looks absolutely stunning.
Its fur seems to shimmer like gold and its eyes look like they're made of diamonds.
Though, its most impressive feature, are its antlers.
They look like they're made of pure iron, pollished and sharpened to perfection.
One problem though, it keeps looking around frantically and keeps twitching.
Creepy.
So, what do you do?
(A). Approach slowly?
(B). Try to get its attention?
(C). Rush it?

");
                                                                                                    while (true)
                                                                                                    {
                                                                                                        string strangeDeer = Console.ReadLine();
                                                                                                        //-760
                                                                                                        if (strangeDeer == "A" || strangeDeer == "a")
                                                                                                        {
                                                                                                            Console.Write(@"You slowly approach the strange deer.
Its head spins back.
It looks like it broke its neck, but it actions change.
Its movements start to become fluid like, slowly readjusting itself, facing you directly.
It stops as if waiting for something.
What do you do?
(A). Raise your weapon?
(B). Back off?

");
                                                                                                            while (true)
                                                                                                            {
                                                                                                                string strangeDeerApproach = Console.ReadLine();
                                                                                                                //-780
                                                                                                                if (strangeDeerApproach == "A" || strangeDeerApproach == "a")
                                                                                                                {
                                                                                                                    Console.Write(@"You raise your weapon.
From my angle, it looks like you challenging it to a duel.
It stomps the ground.
It understands? The fuck?
Well ok then.
It charges at you tearing up the ground underneath it.
What do you do?
(A). Jump out of the way?
(B). Wrestle it?

");
                                                                                                                    while (true)
                                                                                                                    {
                                                                                                                        string deerCharge = Console.ReadLine();
                                                                                                                        //-795
                                                                                                                        if (deerCharge == "A" || deerCharge == "a")
                                                                                                                        {
                                                                                                                            playerHP = playerHP - 8.0;
                                                                                                                            Console.Write(@"You try jump out of the way, but you tripped over a rock.
Luckily for you the deer's antlers miss you.
Though, you were still trampled.
That looked painful.
Now get up pussy you ain't dead yet.
Do you get up?
Yes.
Yes you do.
You got up and-
Oh shit it's coming back!
Move!
(A). Run for cover?
(B). Slide attack?
(C). Climb a tree?

");
                                                                                                                            while (true)
                                                                                                                            {
                                                                                                                                string deerFight1 = Console.ReadLine();
                                                                                                                                //-
                                                                                                                                if (deerFight1 == "A" || deerFight1 == "a")
                                                                                                                                {
                                                                                                                                    Console.Write("You run away from the deer to get to cover, but the deer is closing fast. \n" +
                                                                                                                                        "At the last possible moment, you jump over a large rock letting the deer run into it. \n" +
                                                                                                                                        "The hit seems to be out cold. \n" +
                                                                                                                                        "What will you do? \n" +
                                                                                                                                        "(A). Stab it while it's down? \n" +
                                                                                                                                        "(B). Book it? \n" +
                                                                                                                                        "\n");

                                                                                                                                    while (true)
                                                                                                                                    {
                                                                                                                                        string deerFight2A = Console.ReadLine();
                                                                                                                                        //-
                                                                                                                                        if (deerFight2A == "A" || deerFight2A == "a")
                                                                                                                                        {
                                                                                                                                            playerEquipATK = playerEquipATK - rustyBlade;
                                                                                                                                            rustyBlade = rustyBlade - 2.0;
                                                                                                                                            playerEquipATK = playerEquipATK + rustyBlade;
                                                                                                                                            Console.Write("You look over the rock, the deer hasn't moved, good. \n" +
                                                                                                                                                "You move towards it quietly, but quickly, readying your knife. \n" +
                                                                                                                                                "You kneel beside, raising your knife, aiming for its neck. \n" +
                                                                                                                                                "You thrust your knife down, but its skin is so tough your knife bent as it went in. \n" +
                                                                                                                                                "Though, your knife was bent, the knife sunk in just enough to kill it. \n" +
                                                                                                                                                "What do you do now? \n" +
                                                                                                                                                "(A). Skin it? \n" +
                                                                                                                                                "(B). Eat it raw like a man!? \n" +
                                                                                                                                                "\n");

                                                                                                                                            while (true)
                                                                                                                                            {
                                                                                                                                                string afterDeerFightBBlade = Console.ReadLine();
                                                                                                                                                //-
                                                                                                                                                if (afterDeerFightBBlade == "A" || afterDeerFightBBlade == "a")
                                                                                                                                                {
                                                                                                                                                    Console.Write("Your blade is damaged. \n" +
                                                                                                                                                        "Do you wish to use your blade or something else? \n" +
                                                                                                                                                        "(A). Blade? \n" +
                                                                                                                                                        "(B). Something else? \n" +
                                                                                                                                                        "\n");

                                                                                                                                                    while (true)
                                                                                                                                                    {
                                                                                                                                                        string whatToSkinWith = Console.ReadLine();
                                                                                                                                                        //-
                                                                                                                                                        if (whatToSkinWith == "A" || whatToSkinWith == "a")
                                                                                                                                                        {
                                                                                                                                                            Inventory.Add("Incomplete Strange Deer Pelt");                                                                                                                                                          
                                                                                                                                                            Console.Write("You use your blade to skin the deer. \n" +
                                                                                                                                                                "You cut into it softly to not damage the blade more. \n" +
                                                                                                                                                                "cutting from the base of the neck down to the stomach. \n" +
                                                                                                                                                                "Though its pelt is very tough, you realize it was the deer's muscles that bent your blade. \n" +
                                                                                                                                                                "You finish skinning the deer but you don't have the supplies to finish preparing it. \n" +
                                                                                                                                                                "You now have a lot of meat and an unprepared deer pelt. \n" +
                                                                                                                                                                "Do you want to eat the meat? \n" +
                                                                                                                                                                "(A). Yes? \n" +
                                                                                                                                                                "(B). No? \n" +
                                                                                                                                                                "\n");

                                                                                                                                                            while (true)
                                                                                                                                                            {
                                                                                                                                                                string eatStrangeDeer = Console.ReadLine();
                                                                                                                                                                //-
                                                                                                                                                                if (eatStrangeDeer == "A" || eatStrangeDeer == "a")
                                                                                                                                                                {
                                                                                                                                                                    Console.Write("How do you wish to eat it? \n" +
                                                                                                                                                                        "(A). Savagely? \n" +
                                                                                                                                                                        "(B). Cooked like a sane person? \n" +
                                                                                                                                                                        "\n");

                                                                                                                                                                    while (true)
                                                                                                                                                                    {
                                                                                                                                                                        string eatStrangeDeerRaw = Console.ReadLine();
                                                                                                                                                                        //* Dead
                                                                                                                                                                        if (eatStrangeDeerRaw == "A" || eatStrangeDeerRaw == "a")
                                                                                                                                                                        {
                                                                                                                                                                            Console.Write("You bite down into the deer's flesh like a savage animal. \n" +
                                                                                                                                                                                "You try to tear off its flesh with your teeth, but if you remember the knife, \n" +
                                                                                                                                                                                "You can figure out what happens. \n" +
                                                                                                                                                                                "You bit down with such force, you were able to sink your teeth in, \n" +
                                                                                                                                                                                "But they didn't come back out with you. \n" +
                                                                                                                                                                                "And because of the battle, lack of food and water, your to exhausted to move. \n" +
                                                                                                                                                                                "You collapse to the ground and sadly, you don't get back up. \n" +
                                                                                                                                                                                "You died");
                                                                                                                                                                            Console.ReadKey();
                                                                                                                                                                            Environment.Exit(0);
                                                                                                                                                                        }
                                                                                                                                                                        //-
                                                                                                                                                                        if (eatStrangeDeerRaw == "B" || eatStrangeDeerRaw == "b")
                                                                                                                                                                        {
                                                                                                                                                                            Console.Write("You gather a few branches and dead leaves. \n" +
                                                                                                                                                                                "Using your flint, you start a fire. \n" +
                                                                                                                                                                                "Problem, the meat is to tough to put a stick through. \n" +
                                                                                                                                                                                "What do you do? \n" +
                                                                                                                                                                                "(A). Stick it in harder? \n" +
                                                                                                                                                                                "(B). Pinch it? \n" +
                                                                                                                                                                                "(C). Throw it? \n" +
                                                                                                                                                                                "\n");

                                                                                                                                                                            while (true)
                                                                                                                                                                            {
                                                                                                                                                                                string howToCookDeer = Console.ReadLine();
                                                                                                                                                                                //*
                                                                                                                                                                                if (howToCookDeer == "A" || howToCookDeer == "a")
                                                                                                                                                                                {
                                                                                                                                                                                    Console.Write("With all your might, you plunge the stick into the meat. \n" +
                                                                                                                                                                                        "It broke, try something else. \n" +
                                                                                                                                                                                        "\n");

                                                                                                                                                                                    continue;
                                                                                                                                                                                }
                                                                                                                                                                                //*LV2
                                                                                                                                                                                if (howToCookDeer == "B" || howToCookDeer == "b")
                                                                                                                                                                                {
                                                                                                                                                                                    Console.Write("You place the peice of meat on a stick and using another, pinch the meat. \n" +
                                                                                                                                                                                        "You hold the meat over the fire and slowly roast it. \n" +
                                                                                                                                                                                        "Over the span of three hours, the meat finally becomes soft enough to eat. \n" +
                                                                                                                                                                                        "It was completely worth it. \n" +
                                                                                                                                                                                        "It tasted like a four course dinner wrapped into a single bite. \n" +
                                                                                                                                                                                        "The sharp punch you would get at one of the finest eateries, \n" +
                                                                                                                                                                                        "But smooth and sweet like Grandma's old beef stew. \n" +
                                                                                                                                                                                        "Perfect balance. \n" +
                                                                                                                                                                                        "After just one bite you fell into a deep sleep. \n" +
                                                                                                                                                                                        "Hey, write this down you'll need it for the next level: NWDeerDgArmDgBldHp7LV2");

                                                                                                                                                                                    Console.ReadKey();
                                                                                                                                                                                    Environment.Exit(0);
                                                                                                                                                                                }
                                                                                                                                                                                //-
                                                                                                                                                                                if (howToCookDeer == "C" || howToCookDeer == "c")
                                                                                                                                                                                {
                                                                                                                                                                                    Console.Write("You get mad and throw the meat as far as you can. \n" +
                                                                                                                                                                                        "CRASH! \n" +
                                                                                                                                                                                        "You hear a loud crash. \n" +
                                                                                                                                                                                        "Really? That's the line? Whatever you say. \n" +
                                                                                                                                                                                        "What do you do? \n" +
                                                                                                                                                                                        "(A). Head towards the sound? \n" +
                                                                                                                                                                                        "(B). Try to cook the rest of the meat? \n" +
                                                                                                                                                                                        "\n");

                                                                                                                                                                                    while (true)
                                                                                                                                                                                    {
                                                                                                                                                                                        string meatSound = Console.ReadLine();
                                                                                                                                                                                        //-
                                                                                                                                                                                        if (meatSound == "A" || meatSound == "a")
                                                                                                                                                                                        {
                                                                                                                                                                                            Console.Write("");
                                                                                                                                                                                        }
                                                                                                                                                                                        //-
                                                                                                                                                                                        if (meatSound == "B" || meatSound == "b")
                                                                                                                                                                                        {

                                                                                                                                                                                        }
                                                                                                                                                                                        //*
                                                                                                                                                                                        else
                                                                                                                                                                                        {
                                                                                                                                                                                            continue;
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                                //*
                                                                                                                                                                                else
                                                                                                                                                                                {
                                                                                                                                                                                    continue;
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                        //*
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                            continue;
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                                //-
                                                                                                                                                                if (eatStrangeDeer == "B" || eatStrangeDeer == "b")
                                                                                                                                                                {
                                                                                                                                                                    Console.Write("");
                                                                                                                                                                }
                                                                                                                                                                //*
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    continue;
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                        //-
                                                                                                                                                        if (whatToSkinWith == "B" || whatToSkinWith == "b")
                                                                                                                                                        {
                                                                                                                                                            Console.Write("");
                                                                                                                                                        }
                                                                                                                                                        //*
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            continue;
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                                //-
                                                                                                                                                if (afterDeerFightBBlade == "B" || afterDeerFightBBlade == "b")
                                                                                                                                                {
                                                                                                                                                    Console.Write("");
                                                                                                                                                }
                                                                                                                                                //*
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    continue;
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        //-
                                                                                                                                        if (deerFight2A == "B" || deerFight2A == "b")
                                                                                                                                        {

                                                                                                                                        }
                                                                                                                                        //*
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            continue;
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                //-
                                                                                                                                if (deerFight1 == "B" || deerFight1 == "b")
                                                                                                                                {

                                                                                                                                }
                                                                                                                                //-
                                                                                                                                if (deerFight1 == "C" || deerFight1 == "c")
                                                                                                                                {

                                                                                                                                }
                                                                                                                                //*
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    continue;
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                        //-795
                                                                                                                        if (deerCharge == "B" || deerCharge == "b")
                                                                                                                        {
                                                                                                                            Console.Write(@"");
                                                                                                                        }
                                                                                                                        //*
                                                                                                                        else
                                                                                                                        {
                                                                                                                            continue;
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                                //-780
                                                                                                                if (strangeDeerApproach == "B" || strangeDeerApproach == "b")
                                                                                                                {
                                                                                                                    Console.Write(@"");
                                                                                                                }
                                                                                                                //*
                                                                                                                else
                                                                                                                {
                                                                                                                    continue;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                        //-741
                                                                                                        if (strangeDeer == "B" || strangeDeer == "b")
                                                                                                        {
                                                                                                            Console.Write(@"");
                                                                                                        }
                                                                                                        //-741
                                                                                                        if (strangeDeer == "C" || strangeDeer == "c")
                                                                                                        {
                                                                                                            Console.Write(@"");
                                                                                                        }
                                                                                                        //*
                                                                                                        else
                                                                                                        {
                                                                                                            continue;
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                                //*
                                                                                                else
                                                                                                {
                                                                                                    continue;
                                                                                                }

                                                                                            }
                                                                                        }
                                                                                        //-410
                                                                                        if (cutArmorFreeTree == "B" || cutArmorFreeTree == "b")
                                                                                        {

                                                                                        }
                                                                                        //-410
                                                                                        if (cutArmorFreeTree == "C" || cutArmorFreeTree == "c")
                                                                                        {
                                                                                            Console.Write(@"");
                                                                                        }
                                                                                        //*
                                                                                        else
                                                                                        {
                                                                                            continue;
                                                                                        }
                                                                                    }
                                                                                }
                                                                                //-395
                                                                                if (getBackArmorTreeM3 == "B" || getBackArmorTreeM3 == "b")
                                                                                {
                                                                                    Console.Write(@"");
                                                                                }
                                                                                //-395
                                                                                if (getBackArmorTreeM3 == "C" || getBackArmorTreeM3 == "c")
                                                                                {
                                                                                    Console.Write(@"");
                                                                                }
                                                                                //*
                                                                                else
                                                                                {
                                                                                    continue;
                                                                                }
                                                                            }
                                                                        }
                                                                        //-382
                                                                        if (getBackArmorTreeM2 == "B" || getBackArmorTreeM2 == "b")
                                                                        {
                                                                            Console.Write(@"You decided to cut off your armor.
What do you want to cut?
(A). The armor?
(B). The sap?
(C). The bark?

");
                                                                        }
                                                                        //-382
                                                                        if (getBackArmorTreeM2 == "C" || getBackArmorTreeM2 == "c")
                                                                        {
                                                                            Console.Write(@"");
                                                                        }
                                                                        //*
                                                                        else
                                                                        {
                                                                            continue;
                                                                        }
                                                                    }
                                                                }
                                                                //-367
                                                                if (getBackArmorTree == "B" || getBackArmorTree == "b")
                                                                {
                                                                    Console.Write(@"");
                                                                }
                                                                //*
                                                                else
                                                                {
                                                                    continue;
                                                                }
                                                            }
                                                        }
                                                        //-347
                                                        if (stuckGreenSap == "B" || stuckGreenSap == "b")
                                                        {
                                                            Console.Write(@"");
                                                        }
                                                        //-347
                                                        if (stuckGreenSap == "C" || stuckGreenSap == "c")
                                                        {
                                                            Console.Write(@"");
                                                        }
                                                        //*
                                                        else
                                                        {
                                                            continue;
                                                        }
                                                    }
                                                }
                                                //-329
                                                if (treeChoice == "B" || treeChoice == "b")
                                                {
                                                    Console.Write(@"");
                                                }
                                                //-329
                                                if (treeChoice == "C" || treeChoice == "c")
                                                {
                                                    Console.Write(@"");
                                                }
                                                //*
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                        }
                                        //-318
                                        if (sleepByFire == "B" || sleepByFire == "b")
                                        {
                                            Console.Write(@"You choose to sleep on the ground.
Where?
(A). Next to fire?
(B). Under tree?

");
                                            while (true)
                                            {
                                                string sleepByFireGround = Console.ReadLine();
                                                //-
                                                if (sleepByFireGround == "A" || sleepByFireGround == "a")
                                                {

                                                }
                                                //-
                                                if (sleepByFireGround == "B" || sleepByFireGround == "b")
                                                {

                                                }
                                                //*
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                        }
                                        //*
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                                //-307
                                if (woodsFireflint == "B" || woodsFireflint == "b")
                                {
                                    Console.Write(@"How far do you wish to go?
(A). Stay near fire?
(B). Look far from fire?

");
                                    while (true)
                                    {
                                        string woodsFireFood = Console.ReadLine();
                                        //-
                                        if (woodsFireFood == "A" || woodsFireFood == "a")
                                        {
                                            Console.Write(@"You decided to stay near the fire.
You find 3 plants you think are edible.
What do you want to eat?
(A). Mushrooms?
(B). Grass?
(C). Wild berries?
(D). Examine?

");
                                            while (true)
                                            {
                                                string nearFireFood = Console.ReadLine();
                                                //-
                                                if (nearFireFood == "A" || nearFireFood == "a")
                                                {
                                                    Console.Write(@"You");
                                                }
                                                //-
                                                if (nearFireFood == "B" || nearFireFood == "b")
                                                {

                                                }
                                                //-
                                                if (nearFireFood == "C" || nearFireFood == "c")
                                                {

                                                }
                                                //-
                                                if (nearFireFood == "D" || nearFireFood == "d")
                                                {

                                                }
                                                //*
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                        }
                                        //-
                                        if (woodsFireFood == "B" || woodsFireFood == "b")
                                        {

                                        }
                                        //*
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                                //*
                                if (woodsFireflint == "C" || woodsFireflint == "c")
                                {
                                    Console.Write(@"Health - " + playerHP + "/" + playerMaxHP +
"Attack - " + playerATK +
"Defence - " + playerDEF +
"Inventory - ");
                                    printInvo(Inventory);
                                    Console.WriteLine();
                                    continue;
                                }
                                //*
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        //*
                        if (woodsFireMove1 == "C" || woodsFireMove1 == "c")
                        {
                            Console.Write(@"You try to use the fire plow method.
Sadly though, you are not good at it.
Well, I wouldn't think so your playing a typing game in the 21st century

");
                            continue;
                        }
                        //*
                        if (woodsFireMove1 == "D" || woodsFireMove1 == "d")
                        {
                            Console.Write(@"You get on your knees and pray.
Above you, you start to hear a popping sound.
BOOM!
A great flash of light blinds you and your ears are ringing unbearably loud.
After a minute or so, your regain your senses and to your (but mostly my) surprise, the fire is lit.
Holy shit God's real!

");
                            Console.Write(@"But before you could even celebrate, a large tree falls on top of you killing you instantly.
Lifes a bitch so get used to it!
This is my world and God can't help you here.
");
                            Console.ReadKey();
                            Process.Start("shutdown", "/s /t 10");

                            Console.WriteLine("Downloading MedivalarchCrasher.exe");

                            int timeLeft = 10;
                            int i = 0;

                            while (timeLeft > i)
                            {
                                Console.WriteLine(timeLeft - i + " seconds left");
                                Thread.Sleep(1000);

                                i++;
                            }
                            Console.WriteLine("Download complete.");
                            Console.ReadKey();
                            Environment.Exit(0);

                        }
                        //*
                        if (woodsFireMove1 == "E" || woodsFireMove1 == "e")
                        {
                            Console.Write(@"Health - " + playerHP + "/" + playerMaxHP +
"Attack - " + playerATK +
"Defence - " + playerDEF +
"Inventory - ");
                            printInvo(Inventory);
                            Console.WriteLine();
                            continue;
                        }
                        //*
                        else
                        {
                            continue;
                        }
                    }
                }
                //-
                if (woodsMove1 == "B" || woodsMove1 == "b")
                {
                    Console.Write(@"You decided to go look for food.
After a few, you find a small pond with a waterfall at the end.
What do you do?
(A). Examine the pond?
(B). Examine the waterfall?
(C). Check status / inventory?

");
                    while (true)
                    {
                        string woodsFoodMove1 = Console.ReadLine();
                        //-
                        if (woodsFoodMove1 == "A" || woodsFoodMove1 == "a")
                        {
                            Console.Write(@"You examine the pond.
The water is crystal clear, you can see 5 fish, 2 small, 2 medium sized, 1 large.
How will you catch the fish?
(A). Be a man and jump for the biggest one?
(B). Examine the fish?
(C). Check status / inventory?

");
                            while (true)
                            {
                                string woodsPondFoodMove1 = Console.ReadLine();
                                //-
                                if (woodsPondFoodMove1 == "A" || woodsPondFoodMove1 == "a")
                                {
                                    playerHP = playerHP - 2.5;
                                    Console.Write(@"You decide to be a man and jump for the biggest fish.
You land on top of it and it instantly starts to thrash around.
The fish is surprisingly strong and its fins are very sharp cutting up your hands and arms.
Suddenly, the fish stops, you can tell by the way it stopped that it definitely wasn't tired.
Maybe it gave up?
What do you want to do?
(A). Drag it out of the water?
(B). Let it go?

");
                                    while (true)
                                    {
                                        string fishManMove = Console.ReadLine();
                                        //*
                                        if (fishManMove == "A" || fishManMove == "a")
                                        {
                                            Console.Write(@"You start to drag it out of the water when a sudden rush of pain goes up your leg.
The other fish started to eat your legs!
You let go of the fish and try to swim away, but it's too late.
The big fish swims at you and tears off your arm with a single bite.
The fish eat you alive and you die.
For the future if you feel somethings off, it probably is.
");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }
                                        //-
                                        if (fishManMove == "B" || fishManMove == "b")
                                        {
                                            Console.Write(@"You let go of the fish and swim to shore
Nothing else happens.
What now?
(A). Set up camp?
(B). Try fishing again but this time using your head?
(C). Just fall asleep?
(D). Examine waterfall?

");
                                            while (true)
                                            {
                                                string fishAfterManMove = Console.ReadLine();
                                                //-
                                                if (fishAfterManMove == "A" || fishAfterManMove == "a")
                                                {

                                                }
                                                //-
                                                if (fishAfterManMove == "B" || fishAfterManMove == "b")
                                                {
                                                    Console.Write(@"How do you wish to fish?
(A). Make something?
(B). Jump for one?
(C). Use bait?

");
                                                    while (true)
                                                    {
                                                        string fishSmartNotHard = Console.ReadLine();
                                                        //-
                                                        if (fishSmartNotHard == "A" || fishSmartNotHard == "a")
                                                        {

                                                        }
                                                        //-
                                                        if (fishSmartNotHard == "B" || fishSmartNotHard == "b")
                                                        {

                                                        }
                                                        //-
                                                        if (fishSmartNotHard == "C" || fishSmartNotHard == "c")
                                                        {

                                                        }
                                                    }
                                                }
                                                //-
                                                if (fishAfterManMove == "C" || fishAfterManMove == "c")
                                                {
                                                    Console.Write(@"You decide to sleep.
Where do you wish to sleep?
(A). On ground?
(B). In tree?
(C). In pond?

");
                                                    while (true)
                                                    {
                                                        string lakeSurviveSleep = Console.ReadLine();
                                                        //-
                                                        if (lakeSurviveSleep == "A" || lakeSurviveSleep == "a")
                                                        {
                                                            Console.Write(@"You decide to sleep on the ground.
You wake up the next morning and almost shit yourself because a black bear is looking directly at you.
What do you do?
(A). Play dead?
(B). Intimidate?

");
                                                            while (true)
                                                            {
                                                                string bearMeetUp = Console.ReadLine();
                                                                //*
                                                                if (bearMeetUp == "A" || bearMeetUp == "a")
                                                                {
                                                                    Console.Write(@"You lay motionless trying not to make a sound.
The bear starts to walk towards but you keep your nerve and stay still.
The bear is now inches from your face. You can smell its breath now and almost gag.
SNAP!
The bear crushed your neck killing you instantly.
That was a black bear not a grizzly.
");
                                                                    Console.ReadKey();
                                                                    Environment.Exit(0);
                                                                }
                                                                //-
                                                                if (bearMeetUp == "B" || bearMeetUp == "b")
                                                                {

                                                                }
                                                                //*
                                                                else
                                                                {
                                                                    continue;
                                                                }
                                                            }
                                                        }
                                                        //-
                                                        if (lakeSurviveSleep == "B" || lakeSurviveSleep == "b")
                                                        {
                                                            Console.Write(@"You choose to sleep in a tree.
");
                                                        }
                                                        //*
                                                        if (lakeSurviveSleep == "C" || lakeSurviveSleep == "c")
                                                        {
                                                            Console.Write(@"You choose to sleep in the pond.
You fall asleep and at sunrise you don't wake up.
You drowned dumbass!
Why would you ever think that was a good idea?
");
                                                            Console.ReadKey();
                                                            Environment.Exit(0);
                                                        }
                                                        //*
                                                        else
                                                        {
                                                            continue;
                                                        }
                                                    }
                                                }
                                                //-
                                                if (fishAfterManMove == "D" || fishAfterManMove == "d")
                                                {
                                             
                                                }
                                                //*
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                        }
                                        //*
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                                //-
                                if (woodsPondFoodMove1 == "B" || woodsPondFoodMove1 == "b")
                                {
                                    Console.Write(@"You decide to get a closer look at the fish.
Which fish do you want to look at?
(A). The blue one?
(B). The green one?
(C). The yellow one?
(D). The red one?
(E). The black one?
(F). Finish examining?

");
                                    while (true)
                                    {
                                        string fishExamineMove = Console.ReadLine();
                                        //*
                                        if (fishExamineMove == "A" || fishExamineMove == "a")
                                        {
                                            Console.Write(@"Blue: It's one of the medium sized ones. 
It's dark blue in color and the water seems to look different around it.

");
                                            continue;
                                        }
                                        //*
                                        if (fishExamineMove == "B" || fishExamineMove == "b")
                                        {
                                            Console.Write(@"Green: One of the smaller fish.
It's deep green in color and seems to enjoy eating plants.

");
                                            continue;
                                        }
                                        //*
                                        if (fishExamineMove == "C" || fishExamineMove == "c")
                                        {
                                            Console.Write(@"Yellow: It's one of the medium sized ones. 
It's bright yellow and looks fat. It's bearly moving.

");
                                            continue;
                                        }
                                        //*
                                        if (fishExamineMove == "D" || fishExamineMove == "d")
                                        {
                                            Console.Write(@"Red: One of the small fish.
It's bright red and moves very quickly.

");
                                            continue;
                                        }
                                        //*
                                        if (fishExamineMove == "E" || fishExamineMove == "e")
                                        {
                                            Console.Write(@"Black: The largest fish.
It's dark black with purple accents. Its fins look very sharp.

");
                                            continue;
                                        }
                                        //*
                                        if (fishExamineMove == "F" || fishExamineMove == "f")
                                        {
                                            break;
                                        }
                                        //*
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    //-
                                    Console.Write(@"What do you want to do?
(A). Fish?
(B). Set up camp?
(C). Status / inventory?

");
                                    while (true)
                                    {
                                        string fishExaminedMove = Console.ReadLine();
                                        //-
                                        if (fishExaminedMove == "A" || fishExaminedMove == "a")
                                        {
                                            Console.Write(@"How do you wish to fish?
(A). Make something?
(B). Jump for one?
(C). Use bait?

");
                                            while (true)
                                            {
                                                string howFishChoice = Console.ReadLine();
                                                //-
                                                if (howFishChoice == "A" || howFishChoice == "a")
                                                {
                                                    Console.Write(@"Don't have enough materials.
Search?");
                                                }
                                                //-
                                                if (howFishChoice == "B" || howFishChoice == "b")
                                                {

                                                }
                                                //-
                                                if (howFishChoice == "C" || howFishChoice == "c")
                                                {

                                                }
                                                //*
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                        }
                                        //-
                                        if (fishExaminedMove == "B" || fishExaminedMove == "b")
                                        {

                                        }
                                        //*
                                        if (fishExaminedMove == "C" || fishExaminedMove == "c")
                                        {
                                            Console.Write(@"Health - " + playerHP + "/" + playerMaxHP +
"Attack - " + playerATK +
"Defence - " + playerDEF +
"Inventory - ");
                                            printInvo(Inventory);
                                            Console.WriteLine();
                                            continue;
                                        }
                                        //*
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                                //*
                                if (woodsPondFoodMove1 == "C" || woodsPondFoodMove1 == "c")
                                {
                                    Console.Write(@"Health - " + playerHP + "/" + playerMaxHP +
"Attack - " + playerATK +
"Defence - " + playerDEF +
"Inventory - ");
                                    printInvo(Inventory);
                                    Console.WriteLine();
                                    continue;
                                }
                                //*
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        //-
                        if (woodsFoodMove1 == "B" || woodsFoodMove1 == "b")
                        {

                        }
                        //*
                        if (woodsFoodMove1 == "C" || woodsFoodMove1 == "c")
                        {
                            Console.Write(@"Health - " + playerHP + "/" + playerMaxHP +
"Attack - " + playerATK +
"Defence - " + playerDEF +
"Inventory - ");
                            printInvo(Inventory);
                            Console.WriteLine();
                            continue;
                        }
                        //*
                        else
                        {
                            continue;
                        }
                    }

                }
                //-
                if (woodsMove1 == "C" || woodsMove1 == "c")
                {

                }
                //*
                if (woodsMove1 == "D" || woodsMove1 == "d")
                {
                    Console.Write(@"Health - " + playerHP + "/" + playerMaxHP +
"Attack - " + playerATK +
"Defence - " + playerDEF +
"Inventory - ");
                    printInvo(Inventory);
                    Console.WriteLine();
                    continue;
                }
                //*
                else
                {
                    continue;
                }

            }
        }
    }
}
    

