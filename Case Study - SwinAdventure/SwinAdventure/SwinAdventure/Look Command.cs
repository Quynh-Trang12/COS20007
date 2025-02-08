using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Look_Command : Command
    {
        public Look_Command() : base(new string[] {})
        {

        }       

        public override string Execute(Player p, string[] text)
        {
            IHaveInventory container;

            if (text.Length != 5 && text.Length != 3)
            {
                return "I don't know how to look like that";                
            }

            if (text[0] != "look")
            {
                return  "Error in look input";               
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?";               
            }

            if (text.Length == 5)
            {
                if (text[3] != "in")
                {
                    return "What do you want to look in?";
                }                
            }

            if (text.Length == 3)
            {
                container = p;
            }

            else
            {
                container = FetchContainer(p, text[4]);

                if (container == null)
                {
                    return $"I can't find the {text[4]}";
                }
            }

            return LookAtIn(text[2] , container);
        }

        public IHaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IHaveInventory;            
        }

        public string LookAtIn(string thingId, IHaveInventory container)
        {    
            if (container.Locate(thingId) == null)
            {
                return $"I can't find the {thingId}";
            }
            else return container.Locate(thingId).FullDescription;
        }
    }
}
