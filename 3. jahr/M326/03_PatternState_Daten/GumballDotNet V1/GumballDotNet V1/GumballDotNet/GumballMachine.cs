using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballDotNet
{
    public class GumballMachine
    {
        private IState soldOutState;
        private IState noQuarterState;
        private IState hasQuarterState;
        private IState soldState;

        private IState state;
        int count = 0;

        public GumballMachine(int count)
        {
            soldOutState = new soldOutState(this);
            soldOutState = new noQuarterState(this);
            soldOutState = new hasQuarterState(this);
            soldOutState = new soldState(this);



            this.count = count;
            if (count > 0) {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }

                state = NO_QUARTER;
        }

        public void insertQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("You can't insert another quarter");
            }
            else if (state == NO_QUARTER)
            {
                state = HAS_QUARTER;
                Console.WriteLine("You inserted a quarter");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You can't insert a quarter, the machine is sold out");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("Please wait, we're already giving you a gumball");
            }
        }

        public void ejectQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned");
                state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You haven't inserted a quarter");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("Sorry, you already turned the crank");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
            }
        }

        public void turnCrank()
        {
            if (state == SOLD)
            {
                Console.WriteLine("Turning twice doesn't get you another gumball!");
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You turned but there's no quarter");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You turned, but there are no gumballs");
            }
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine("You turned...");
                state = SOLD;
                dispense();
            }
        }

        private void dispense()
        {
            if (state == SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot");
                count = count - 1;
                if (count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    state = SOLD_OUT;
                }
                else
                {
                    state = NO_QUARTER;
                }
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You need to pay first");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("No gumball dispensed");
            }
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine("No gumball dispensed");
            }
        }

        public void refill(int numGumBalls)
        {
            this.count = numGumBalls;
            state = NO_QUARTER;
        }

        public override String ToString()
        {
            String result ="";
            result+="\nMighty Gumball, Inc.";
            result += "\nJava-enabled Standing Gumball Model #2004\n";
            result += "Inventory: " + count + " gumball";
            if (count != 1)
            {
                result +="s";
            }
            result += "\nMachine is ";
            if (state == SOLD_OUT)
            {
                result += "sold out";
            }
            else if (state == NO_QUARTER)
            {
                result += "waiting for quarter";
            }
            else if (state == HAS_QUARTER)
            {
                result += "waiting for turn of crank";
            }
            else if (state == SOLD)
            {
                result += "delivering a gumball";
            }
            result+= "\n";
            return result;
        }
    }
}
